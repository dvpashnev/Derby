   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  	 Derby   Derby.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     9system&clr-namespace:System;assembly=mscorlib     -   $��MainWin��  � Title$  The WPF Derby��$	��710��$	��710�� � Topmost .  � WindowStartupLocation$ CenterScreen=� � 	Resources    BgImageBrush �� ImageSource j� Stretch �� Opacity  
FirstBrush �� 
StartPoint �� EndPoint	 � Color
 � Offset  DownPanelBrush  
TrackStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding J� SnapsToDevicePixels �� CornerRadius  TrackEndStyle  DownPanelStyle  TrackWinnerStyle  TrackLoserStyle��%  &	        &	 /     &	 �     &	 �     7  &	 �    &	 �    7  &	 t    &	 �    �� $ Background.jpg��$
 Fill=�$	 0.3Q��� $	 0,1&�$	 0,0&�$	 0.7Q�.��� $	 Black��$	
 0.0Q�� $	 Transparent��$
 4Q��� $	 0,1&�$	 0,0&�.��� $	 Green��$
 0Q�� $	 White��$
 1Q��� " ��.���  � ��
 �������  � ��$ 15(���  � �� �� " ��.R��� $��1q�$ 0q�
�������8��   . $ 8��$	��0,3q�$��65��._��� ��. �� " ��.���  � ��
 �������  � ��$ 15(���  � �� �� " ��.R��� $��1q�$ 0q�
������� . $ 8��$��0q�$��65������ $	 0,0&�$	 1,0&�$	 0.8Q�.��� $	 GreenYellow��$
 1Q�� $	 Green��$

 0.98Q�� $	 Transparent��$	
 0.0Q�._��� ��. $��Center=��� " ��.���  � ��
 �   ���  � ��$ 15(���  � �� �� " ��.R��� $��1q�$ 2q�
�������8��   . $ 8��$��0q�$��30��._��� ��. �� " ��.���  � ��
 �   ���  � ��$ 15(���  � ��$
 Bold"���  � �� �� " ��.R��� $��2q�$ 0q�
������� . $ 8��$��0q�$��65������ $	 1,1&�$	 1,0&�.��� $	 NavajoWhite��$
 1Q�� $	 Yellow��$	
 0.0Q�._��� ��. $��Center=�$��Center=��� " ��.���  � ��
 �������  � ��$ 15(���  � �� �� " ��.R��� $��1q�$ 0q�
������� . $ 8��$��0q�$��65������ $	 0,1&�$	 0,0&�$	 0.8Q�.��� $	 Black��$	
 0.0Q�� $		 Red��$
 2Q�._��� ��.  � Triggers :�  :� RoutedEvent$ Window.Loaded��.[��� .���� -    g�Name$ DerbyAnimation��.��W�  �� 
TargetName$ DashLuckyBell�� �� TargetProperty$ Width� W� From$ 0X� g� Duration$ 0:0:5D�	 W� To ��  �� ElementName$ TracksLabel�� �� Path$ ActualWidth� �� UpdateSourceTrigger$ PropertyChanged=�W� $ DashSweetFate��$ Width�$ 0X�$ 0:0:5D� �� $ TracksLabel��$ ActualWidth�$ PropertyChanged=�W� $ DashMrKentucky��$ Width�$ 0X�$ 0:0:5D� �� $ TracksLabel��$ ActualWidth�$ PropertyChanged=�W� $ DashFreshSpice��$ Width�$ 0X�$ 0:0:5D� �� $ TracksLabel��$ ActualWidth�$ PropertyChanged=�W� $ DashBluegrass��$ Width�$ 0X�$ 0:0:5D� �� $ TracksLabel��$ ActualWidth�$ PropertyChanged=�W� $ DashKitMadison��$ Width�$ 0X�$ 0:0:5D� �� $ TracksLabel��$ ActualWidth�$ PropertyChanged=�.��� -   $��MainGrid��#��[   � RowDefinitions �� $��* ��� $��40 �.+��� -   $��TracksLabel��$��0�� J� RenderTransformOrigin$ 0.5, 0.5&�$��0q�$��10,10q�$��Center=� � LayoutTransform ��   �� Angle  �� $ Slider��$ Value�.��� -   $��TracksPanel��$��Center=����� $ TracksLabel��$ ActualWidth� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� -   $��	LuckyBell��$��0��#��[ .��� .+��� $��Center=�
Lucky Bell�� ! �� Orientation$! 
Horizontal=�$��Center=�.+��� -   $��DashLuckyBell��#��[ $��0��$
��Left=����� $ 	LuckyBell��$ ActualWidth��� -   $��HorseImage0��$��RaceHorse.gif��$��60���� -	   $��LuckyBellWinner��#��[ " J� Opacity$" 0Q�.���� $��Center=�
Lucky Bell�� -
   $��LuckyBellLoser��$��0��#��[ $" 0Q����� $ TracksLabel��$ ActualWidth�.���� $��Center=�
Lucky Bell# � ToolTip# _� 
�������$ _� 	Placement$$ Mouse=��� -   $��	SweetFate��$��1��#��[ .��� .+��� $��Center=�
Sweet Fate�� $! 
Horizontal=�$��Center=�.+��� -   $��DashSweetFate��#��[ $��0��$
��Left=�$" 1Q����� $ 	SweetFate��$ ActualWidth��� -   $��HorseImage1��$��RaceHorse.gif��$��60���� -   $��SweetFateWinner��#��[ $" 0Q�.���� $��Center=�
Sweet Fate�� -   $��SweetFateLoser��$��1��#��[ $" 0Q����� $ TracksLabel��$ ActualWidth�.���� $��Center=�
Sweet Fate# _� 
�������$$ Mouse=��� -   $��
MrKentucky��$��2��#��[ .��� .+��� $��Center=�Mr. Kentucky�� $! 
Horizontal=�$��Center=�.+��� -   $��DashMrKentucky��#��[ $��0��$
��Left=����� $ 
MrKentucky��$ ActualWidth��� -   $��HorseImage2��$��RaceHorse.gif��$��60���� -   $��MrKentuckyWinner��#��[ $" 0Q�.���� $��Center=�Mr. Kentucky�� -   $��MrKentuckyLoser��$��2��#��[ $" 0Q����� $ TracksLabel��$ ActualWidth�.���� $��Center=�Mr. Kentucky# _� 
�������$$ Mouse=��� -   $��
FreshSpice��$��3��#��[ .��� .+��� $��Center=�Fresh Spice�� $! 
Horizontal=�$��Center=�.+��� -   $��DashFreshSpice��#��[ $��0��$
��Left=����� $ 
FreshSpice��$ ActualWidth��� -   $��HorseImage3��$��RaceHorse.gif��$��60���� -   $��FreshSpiceWinner��#��[ $" 0Q�.���� $��Center=�Fresh Spice�� -   $��FreshSpiceLoser��$��3��#��[ $" 0Q����� $ TracksLabel��$ ActualWidth�.���� $��Center=�Fresh Spice# _� 
�������$$ Mouse=��� -   $��	Bluegrass��$��4��#��[ .��� .+��� $��Center=�	Bluegrass�� $! 
Horizontal=�$��Center=�.+��� -   $��DashBluegrass��#��[ $��0��$
��Left=����� $ 	Bluegrass��$ ActualWidth��� -   $��HorseImage4��$��RaceHorse.gif��$��60���� -   $��BluegrassWinner��$��0��#��[ $" 0Q�.���� $��Center=�	Bluegrass�� -   $��BluegrassLoser��$��4��#��[ $" 0Q����� $ TracksLabel��$ ActualWidth�.���� $��Center=�	Bluegrass# _� 
�������$$ Mouse=��� -   $��
KitMadison��$��5��#��[ .��� .+��� $��Center=�Kit Madison�� $! 
Horizontal=�$��Center=�.+��� -    $��DashKitMadison��#��[ $��0��$
��Left=����� $ 
KitMadison��$ ActualWidth��� -!   $��HorseImage5��$��RaceHorse.gif��$��60���� -"   $��KitMadisonWinner��$��0��#��[ $" 0Q�.���� $��Center=�Kit Madison�� -#   $��KitMadisonLoser��$��5��#��[ $" 0Q����� $ TracksLabel��$ ActualWidth�.���� $��Center=�Kit Madison# _� 
�������$$ Mouse=��� -$   $��	DownPanel��$��1��#��[ $��30��$��10(�.���� .+��� $! 
Horizontal=�.+��� $��14(�$��	10,0,10,0q�	Rotation:�� -%   $��Slider��$	��100��% � Minimum$	% -90Q�& � Maximum$& 90Q�' �� Interval$' 1��( � SmallChange$( 1Q�) � LargeChange$) 1Q�* �� IsSnapToTickEnabled* . �� $��14(�$��	10,0,10,0q��� ��� $ Slider��$ Value�
 degrees�� $��14(�$��	10,0,10,0q�+ �� Right$+ 0���� -&   , �Name$, cmdStop��.�Start new race!