using System;
using System.Threading;
using System.Windows;
using System.Windows.Media.Animation;

namespace Derby
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private Storyboard winner = new Storyboard();

    private int winnerNumber;

    private string winnerName;

    private Storyboard loser = new Storyboard();

    public MainWindow()
    {
      InitializeComponent();

      DoubleAnimation winnerDoubleAnimation = new DoubleAnimation();
      Storyboard.SetTargetProperty(winner, new PropertyPath("Opacity"));
      winnerDoubleAnimation.From = 0;
      winnerDoubleAnimation.To = 1;
      winnerDoubleAnimation.Duration = new Duration(new TimeSpan(0, 0, 0));

      winner.Children.Add(winnerDoubleAnimation);

      DoubleAnimation loserDoubleAnimation0 = new DoubleAnimation();
      Storyboard.SetTargetProperty(loserDoubleAnimation0, new PropertyPath("Opacity"));
      loserDoubleAnimation0.From = 1;
      loserDoubleAnimation0.To = 0;
      loserDoubleAnimation0.Duration = new Duration(new TimeSpan(0, 0, 0));
      loser.Children.Add(loserDoubleAnimation0);

      DoubleAnimation loserDoubleAnimation1 = new DoubleAnimation();
      Storyboard.SetTargetProperty(loserDoubleAnimation1, new PropertyPath("Opacity"));
      loserDoubleAnimation1.From = 1;
      loserDoubleAnimation1.To = 0;
      loserDoubleAnimation1.Duration = new Duration(new TimeSpan(0, 0, 0));
      loser.Children.Add(loserDoubleAnimation1);

      DoubleAnimation loserDoubleAnimation2 = new DoubleAnimation();
      Storyboard.SetTargetProperty(loserDoubleAnimation2, new PropertyPath("Opacity"));
      loserDoubleAnimation2.From = 0;
      loserDoubleAnimation2.To = 1;
      loserDoubleAnimation2.Duration = new Duration(new TimeSpan(0, 0, 0));
      loser.Children.Add(loserDoubleAnimation2);

      DoubleAnimation loserDoubleAnimation3 = new DoubleAnimation();
      Storyboard.SetTargetProperty(loserDoubleAnimation3, new PropertyPath("Opacity"));
      loserDoubleAnimation3.From = 1;
      loserDoubleAnimation3.To = 0.5;
      loserDoubleAnimation3.Duration = new Duration(new TimeSpan(0, 0, 1));
      loser.Children.Add(loserDoubleAnimation3);

      SetSpeedRatios();

    }

    private void SetSpeedRatios()
    {
      double max = -1;

      int i = 0;

      for (; i < 6; i++)
      {
        double rand = new Random((int)DateTime.Now.Ticks).NextDouble() + 0.5;
        Thread.Sleep(5);
        DerbyAnimation.Children[i].SpeedRatio = rand;

        if (max < rand)
        {
          winnerNumber = i;
          max = rand;
        }          
      }
    }

    private void Hyperlink_OnClick(object sender, RoutedEventArgs e)
    {

      LuckyBellWinner.BeginAnimation(OpacityProperty, null);
      LuckyBellLoser.BeginAnimation(OpacityProperty, null);
      DashLuckyBell.BeginAnimation(OpacityProperty, null);
      LuckyBell.BeginAnimation(OpacityProperty, null);
      
      SweetFate.BeginAnimation(OpacityProperty, null);
      SweetFateWinner.BeginAnimation(OpacityProperty, null);
      DashSweetFate.BeginAnimation(OpacityProperty, null);
      SweetFateLoser.BeginAnimation(OpacityProperty, null);

      MrKentucky.BeginAnimation(OpacityProperty, null);
      MrKentuckyWinner.BeginAnimation(OpacityProperty, null);
      DashMrKentucky.BeginAnimation(OpacityProperty, null);
      MrKentuckyLoser.BeginAnimation(OpacityProperty, null);

      FreshSpice.BeginAnimation(OpacityProperty, null);
      FreshSpiceWinner.BeginAnimation(OpacityProperty, null);
      DashFreshSpice.BeginAnimation(OpacityProperty, null);
      FreshSpiceLoser.BeginAnimation(OpacityProperty, null);

      Bluegrass.BeginAnimation(OpacityProperty, null);
      BluegrassWinner.BeginAnimation(OpacityProperty, null);
      DashBluegrass.BeginAnimation(OpacityProperty, null);
      BluegrassLoser.BeginAnimation(OpacityProperty, null);

      KitMadison.BeginAnimation(OpacityProperty, null);
      KitMadisonWinner.BeginAnimation(OpacityProperty, null);
      DashKitMadison.BeginAnimation(OpacityProperty, null);
      KitMadisonLoser.BeginAnimation(OpacityProperty, null);

      SetSpeedRatios();

      DerbyAnimation.Begin();
    }

    private void Slider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
      if (Slider.Value == 90 || Slider.Value == -90)
      {
        TracksLabel.VerticalAlignment = VerticalAlignment.Stretch;
      }
      else
      {
        TracksLabel.VerticalAlignment = VerticalAlignment.Center;
      }
    }

    private void Dash_OnSizeChanged(object sender, SizeChangedEventArgs e)
    {
      double LuckyBellPercents = Math.Round((DashLuckyBell.ActualWidth / TracksLabel.ActualWidth) * 100);

      LuckyBellLoser.ToolTip = LuckyBellPercents + " % finished";

      if (LuckyBellPercents > 99)
      {
        if (winnerNumber == 0)
        {
          Storyboard.SetTargetName(winner, "LuckyBellWinner");
          winner.Begin(LuckyBellWinner, true);
        }
        else
        {
          Storyboard.SetTargetName(loser.Children[0], "LuckyBell");
          Storyboard.SetTargetProperty(LuckyBell, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[1], "DashLuckyBell");
          Storyboard.SetTargetProperty(DashLuckyBell, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[2], "LuckyBellLoser");
          Storyboard.SetTargetProperty(LuckyBellLoser, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[3], "LuckyBellLoser");
          Storyboard.SetTargetProperty(LuckyBellLoser, new PropertyPath(OpacityProperty));

          loser.Begin(TracksPanel, true);
        }
      }

      double SweetFatePercents = Math.Round((DashSweetFate.ActualWidth / TracksLabel.ActualWidth) * 100);
      SweetFateLoser.ToolTip = SweetFatePercents + " % finished";
      if (SweetFatePercents > 99)
      {
        if (winnerNumber == 1)
        {
          Storyboard.SetTargetName(winner, "SweetFateWinner");
          winner.Begin(SweetFateWinner, true);
        }
        else
        {
          Storyboard.SetTargetName(loser.Children[0], "SweetFate");
          Storyboard.SetTargetProperty(LuckyBell, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[1], "DashSweetFate");
          Storyboard.SetTargetProperty(DashLuckyBell, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[2], "SweetFateLoser");
          Storyboard.SetTargetProperty(LuckyBellLoser, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[3], "SweetFateLoser");
          Storyboard.SetTargetProperty(LuckyBellLoser, new PropertyPath(OpacityProperty));

          loser.Begin(TracksPanel, true);
        }
      }

      double MrKentuckyPercents = Math.Round((DashSweetFate.ActualWidth / TracksLabel.ActualWidth) * 100);
      MrKentuckyLoser.ToolTip = MrKentuckyPercents + " % finished";
      if (MrKentuckyPercents > 99)
      {
        if (winnerNumber == 2)
        {
          Storyboard.SetTargetName(winner, "MrKentuckyWinner");
          winner.Begin(MrKentuckyWinner, true);
        }
        else
        {
          Storyboard.SetTargetName(loser.Children[0], "MrKentucky");
          Storyboard.SetTargetProperty(LuckyBell, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[1], "DashMrKentucky");
          Storyboard.SetTargetProperty(DashLuckyBell, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[2], "MrKentuckyLoser");
          Storyboard.SetTargetProperty(LuckyBellLoser, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[3], "MrKentuckyLoser");
          Storyboard.SetTargetProperty(LuckyBellLoser, new PropertyPath(OpacityProperty));

          loser.Begin(TracksPanel, true);
        }
      }

      double FreshSpicePercents = Math.Round((DashSweetFate.ActualWidth / TracksLabel.ActualWidth) * 100);
      FreshSpiceLoser.ToolTip = FreshSpicePercents + " % finished";
      if (FreshSpicePercents > 99)
      {
        if (winnerNumber == 3)
        {
          Storyboard.SetTargetName(winner, "FreshSpiceWinner");
          winner.Begin(FreshSpiceWinner, true);
        }
        else
        {
          Storyboard.SetTargetName(loser.Children[0], "FreshSpice");
          Storyboard.SetTargetProperty(LuckyBell, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[1], "DashFreshSpice");
          Storyboard.SetTargetProperty(DashLuckyBell, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[2], "FreshSpiceLoser");
          Storyboard.SetTargetProperty(LuckyBellLoser, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[3], "FreshSpiceLoser");
          Storyboard.SetTargetProperty(LuckyBellLoser, new PropertyPath(OpacityProperty));

          loser.Begin(TracksPanel, true);
        }
      }

      double BluegrassPercents = Math.Round((DashSweetFate.ActualWidth / TracksLabel.ActualWidth) * 100);
      BluegrassLoser.ToolTip = BluegrassPercents + " % finished";
      if (BluegrassPercents > 99)
      {
        if (winnerNumber == 4)
        {
          Storyboard.SetTargetName(winner, "BluegrassWinner");
          winner.Begin(BluegrassWinner, true);
        }
        else
        {
          Storyboard.SetTargetName(loser.Children[0], "Bluegrass");
          Storyboard.SetTargetProperty(LuckyBell, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[1], "DashBluegrass");
          Storyboard.SetTargetProperty(DashLuckyBell, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[2], "BluegrassLoser");
          Storyboard.SetTargetProperty(LuckyBellLoser, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[3], "BluegrassLoser");
          Storyboard.SetTargetProperty(LuckyBellLoser, new PropertyPath(OpacityProperty));

          loser.Begin(TracksPanel, true);
        }
      }

      double KitMadisonPercents = Math.Round((DashSweetFate.ActualWidth / TracksLabel.ActualWidth) * 100);
      KitMadisonLoser.ToolTip = KitMadisonPercents + " % finished";
      if (KitMadisonPercents > 99)
      {
        if (winnerNumber == 5)
        {
          Storyboard.SetTargetName(winner, "KitMadisonWinner");
          winner.Begin(KitMadisonWinner, true);
        }
        else
        {
          Storyboard.SetTargetName(loser.Children[0], "KitMadison");
          Storyboard.SetTargetProperty(LuckyBell, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[1], "DashKitMadison");
          Storyboard.SetTargetProperty(DashLuckyBell, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[2], "KitMadisonLoser");
          Storyboard.SetTargetProperty(LuckyBellLoser, new PropertyPath(OpacityProperty));

          Storyboard.SetTargetName(loser.Children[3], "KitMadisonLoser");
          Storyboard.SetTargetProperty(LuckyBellLoser, new PropertyPath(OpacityProperty));

          loser.Begin(TracksPanel, true);
        }
      }
    }
  }
}
