   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.AccountWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $	��600��5      $
��1080��67     � 
ResizeMode$  NoResize=�6D    � WindowStartupLocation$ CenterScreen=�6Z   
������� � 	Resources 5	         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5
   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $	 150Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 150Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6   	 :� 
SourceName$	 ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $ ButtonBase.Click��6   $	 ButtonCloseMenu��66   .[�5      �� #��[ 6   5      .��5!      � .+�5#   
   � $��60��6   $	��Top=�6   ���	#FF26569B.+�5$      �� $��	AE de IHC��6   $��Center=�6)   $��Center=�6F   $��22(�6a   6q   �� 5%      $��Center=�6   
 �� Orientation$
 
Horizontal=�64   $��Right=�6M   .+�5'      '  !MaterialDesignThemes.Wpf.PopupBox  $��10q�6*      PlacementMode$ BottomAndAlignRightEdges=�66      	StaysOpen .     PopupContent. 5(      �� $	��150��6!   .+�5)      �� -   5        $��Account��5)   !   63   �� 5*      $��Settings��6!   �� 5+      6&   �� 5,      -   5         ��Name$ BottonPopUpLogout��5,   !   $��Logout��6<   6M   5-      5.      5/      50      � 52   
   $��	60 60 0 0q�6   ��53      �� 54       �� ImageSource$ Backgrounds/home.jpg��6   6B   .+�56      � $	��280��6   $	��270��6   $��Center=�6,   $��10q�6G   
�������.+�57      �� $��PASSWORD CHANGE��6   $��Center=�63   $	��Top=�6P   $��5q�6h   
�������$��18(�6�   6�   �� 58      $��Center=�6   $��10q�68   .+�59      G� -   5         G�Name$ txtPassword1��59   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ CURRENT PASSWORD��68    ) %MaterialDesignFloatingHintPasswordBox#��[ 6j   $
��0 10q�6�   
�������$��18(�6�   6�   G� 5:      -   5        $ txtPassword2��5:   "   $ NEW PASSWORD��68   #��[ 6f   $
��0 10q�6�   
�������$��18(�6�   6�   G� 5;      -   5        $ txtPassword3��5;   "   $ CONFIRM NEW PASSWORD��68   #��[ 6n   $
��0 10q�6�   
�������$��18(�6�   6�   5<      5=      �� 5>      -   5        $ Confirm��5>      $��0,105q�6;   $��Bottom=�6J   $	��150��6e   $��CONFIRM��6q   6�   �� 5?      -   5         ��Name$ label1��5?      $�� ��6$   $��Bottom=�6/   $��Center=�6J   $��10q�6g   
���  ��$y�Visible=�6�   6�   5@      � 5B   
   -	   5         �Name$ GridMenu��5B      $��60��6!   $
��Left=�6,   ���	#FF211874.+�5C      �� .+�5E      � $��60��6   
�������.+�5F      �� -
   5        $ ButtonCloseMenu��5F      $��60��66   $��60��6A   $	��Top=�6{   $��Right=�6�   $y�	Collapsed=�6�   ��6M   Z� ��6c   Z� .��5G      '  !MaterialDesignThemes.Wpf.PackIcon  ���	#FF211874�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ 	ArrowLeft=�6I   $��25��6Z   $��25��6e   5H      �� 5I      -   5        $ ButtonOpenMenu��5I      $��60��65   $��60��6@   $	��Top=�6z   $��Right=�6�   ��6L   Z� ��6b   Z� .��5J        ���	#FF211874$
 Menu=�6I   $��25��6U   $��25��6`   5K      5L      �� 5N      $��Disabled=�6   ���	#FF26569B.@�5O      �� -   5        $��60��5O   #   .��5P      �� $
 
Horizontal=�6%   .+�5Q        $
 Home=�66   $��25��6B   $��25��6M   $��10q�6Y   $��Center=�6e   6�   �� 5R      $
��Home��6(   $��Center=�64   $��10 10q�6O   6`   5S      5T      �� 5V      $��60��6#   .��5W      �� $
 
Horizontal=�6%   .+�5X        $��Center=�66   $��25��6S   $��25��6^   $��10q�6j   $��Center=�6v   $ RightAndAlignTopEdges=�6�    .     ToggleContent 5Y   "     5Z   &   $ Human=�6>   $��25��6K   $��25��6V   ���	#FF26569B6b   . 5\   "   �� .+�5]   &   �� -   5        $��Register New Member��5]   -   6h   �� 5^   &   -   5        $��Renew Member��5^   -   6`   5`   #   5a      �� 5b      $��Members��6(   $��Center=�67   $��10 10q�6R   6c   5c      5d      �� 5e      $��60��6#   .��5f      �� $
 
Horizontal=�6%   .+�5g        $��Center=�66   $��25��6S   $��25��6^   $��10q�6j   $��Center=�6v   $ RightAndAlignTopEdges=�6�    .   5h   "     5i   &   $ DatabaseSearch=�6>   $��25��6T   $��25��6_   ���	#FF26569B6k   . 5k   "   �� .+�5l   &   �� -   5        $��Events��5l   -   6S   �� 5m   &   -   5        $��Reunions��5m   -   6X   �� 5o   &   -   5        $��Sponsors��5o   -   6X   5p   #   5q      �� 5r      $��Organization��6(   $��Center=�6<   $��10 10q�6W   6h   5s      5t      �� 5u      -   5        $��60��5u   #   .��5v      �� $
 
Horizontal=�6%   .+�5w        $
 Star=�66   $��25��6B   $��25��6M   $��10q�6Y   $��Center=�6e   �� 5x      $��Extra��6(   $��Center=�65   $��10 10q�6P   5y      5z      �� 5{      -   5        $��60��5{   #   .��5|      �� $
 
Horizontal=�6%   .+�5}        $ 	GithubBox=�66   $��25��6G   $��25��6R   $��10q�6^   $��Center=�6j   �� 5~      $��GitHub��6(   $��Center=�66   $��10 10q�6Q   5      5�      5�      5�      5�      5�      5�      