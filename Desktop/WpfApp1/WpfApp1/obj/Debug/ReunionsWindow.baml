   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.ReunionsWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5      $
��1080��6'     � 
ResizeMode$  NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J   
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
Horizontal=�64   $��Right=�6M   .+�5&      '  !MaterialDesignThemes.Wpf.PopupBox  $��10q�6*      PlacementMode$ BottomAndAlignRightEdges=�66      	StaysOpen .     PopupContent. 5'      �� $	��150��6!   .+�5(      �� -   5        $��Account��5(   !   63   �� 5)      $��Settings��6!   �� 5*      6&   �� 5+      -   5         ��Name$ BottonPopUpLogout��5+   !   $��Logout��6<   6M   5,      5-      5.      5/      � 51   
   $��	60 60 0 0q�6   ��52      �� 53       �� ImageSource$ Backgrounds/home.jpg��6   6B   .+�55      �� $��50q�6   $��30(�6    
�������$��2��6A   .��6U   This Week's Reunions6k   �� 56      $��50 100q�6   $��20(�6$   
�������$��2��6E   .��6Y   Monday 21st May @ 10am6q   �� 57      $��50 125q�6   $��16(�6$   
�������$��2��6E   .��6Y   @>-> We need to discuss an event sponsored by Aveiro's hospital.6�   �� 58      $��50 175q�6   $��20(�6$   
�������$��2��6E   .��6Y   Tuesday 22nd May @ 11am6r   �� 59      $��50 200q�6   $��16(�6$   
�������$��2��6E   .��6Y   75-> Talking with our treasurer; How good are we going?6�   �� 5:      $��Right=�6   $��Bottom=�65   $��25q�6P   .+�5;        $��10q�6*   $ BottomAndAlignRightEdges=�66    .     ToggleContent 5<      '  !MaterialDesignThemes.Wpf.PackIcon  5=      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ PlusBox=�62   $��30��6A   $��30��6L   
�������6X   . 5?      �� $	��150��6!   .+�5@      �� -   5        $��New Reunion��5@   !   67   5A      5B      5C      5D      � 5F   
   -   5         �Name$ GridMenu��5F      $��60��6!   $
��Left=�6,   ���	#FF211874.+�5G      �� .+�5H      � $��60��6   
�������.+�5I      �� -   5        $ ButtonCloseMenu��5I      $��60��66   $��60��6A   $	��Top=�6{   $��Right=�6�   $y�	Collapsed=�6�   ��6M   Z� ��6c   Z� .��5J        ���	#FF211874$ 	ArrowLeft=�6I   $��25��6Z   $��25��6e   5K      �� 5L      -   5        $ ButtonOpenMenu��5L      $��60��65   $��60��6@   $	��Top=�6z   $��Right=�6�   ��6L   Z� ��6b   Z� .��5M        ���	#FF211874$
 Menu=�6I   $��25��6U   $��25��6`   5N      5O      �� 5Q      $��Disabled=�6   ���	#FF26569B.@�5R      �� -   5        $��60��5R   #   .��5S      �� $
 
Horizontal=�6%   .+�5T        $
 Home=�66   $��25��6B   $��25��6M   $��10q�6Y   $��Center=�6e   6�   �� 5U      $
��Home��6(   $��Center=�64   $��10 10q�6O   6`   5V      5W      �� 5Y      $��60��6#   .��5Z      �� $
 
Horizontal=�6%   .+�5[        $��Center=�66   $��25��6S   $��25��6^   $��10q�6j   $��Center=�6v   $ RightAndAlignTopEdges=�6�    .   5\   "     5]   &   $ Human=�6>   $��25��6K   $��25��6V   ���	#FF26569B6b   . 5_   "   �� .+�5`   &   �� -   5        $��Register New Member��5`   -   6h   �� 5a   &   -	   5        $��Renew Member��5a   -   6`   5c   #   5d      �� 5e      $��Members��6(   $��Center=�67   $��10 10q�6R   6c   5f      5g      �� 5h      $��60��6#   .��5i      �� $
 
Horizontal=�6%   .+�5j        $��Center=�66   $��25��6S   $��25��6^   $��10q�6j   $��Center=�6v   $ RightAndAlignTopEdges=�6�    .   5k   "     5l   &   $ DatabaseSearch=�6>   $��25��6T   $��25��6_   ���	#FF26569B6k   . 5n   "   �� .+�5o   &   �� -
   5        $��Events��5o   -   6S   �� 5p   &   -   5        $��Reunions��5p   -   6X   �� 5r   &   -   5        $��Sponsors��5r   -   6X   5s   #   5t      �� 5u      $��Organization��6(   $��Center=�6<   $��10 10q�6W   6h   5v      5w      �� 5x      -   5        $��60��5x   #   .��5y      �� $
 
Horizontal=�6%   .+�5z        $
 Star=�66   $��25��6B   $��25��6M   $��10q�6Y   $��Center=�6e   �� 5{      $��Extra��6(   $��Center=�65   $��10 10q�6P   5|      5}      �� 5~      -   5        $��60��5~   #   .��5      �� $
 
Horizontal=�6%   .+�5�        $ 	GithubBox=�66   $��25��6G   $��25��6R   $��10q�6^   $��Center=�6j   �� 5�      $��GitHub��6(   $��Center=�66   $��10 10q�6Q   5�      5�      5�      5�      5�      5�      5�      