   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   !localclr-namespace:WpfApp1  5   	   $	��500��5      $	��350��6'     � 
ResizeMode$  NoResize=�63    � WindowStartupLocation$ CenterScreen=�6I   
�������.��5	      � .+�5
   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF26569B��6#   67   5      5      �� 5   
   $��Backgrounds/login.png��6   $	��100��6/   $	��100��6;   $	��Top=�6H   $��20q�6`   6n   �� 5   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $��0,100q�6U    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FFBBBBBB��6#      	Direction$ 0Q�65      RenderingBias$ Quality=�6C   	   
BlurRadius$	 15Q�6[   
   ShadowDepth$
 1Q�6k   6}   5      � 5   
   $	��280��6   $	��240��6   $��Bottom=�6(   $��0,100q�6C   .+�5      �� $��LOGIN��6   $��Center=�6%   $	��Top=�6B   $��5q�6Z   
�������$��18(�6w   6�   �� 5      $��Center=�6   $��10q�64   .+�5      �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ EMAIL��6    %  !MaterialDesignFloatingHintTextBox#��[  6A   $
��0 10q�6|   
�������$��18(�6�   .��6�   ��5      �� 5       �� Path$
 Name�6"    �� UpdateSourceTrigger$ PropertyChanged=�6.    �� ValidationRules 5         WpfApp1.EmailValidator  5   "   5       .��5!   $   5"      G� 5$      $ PASSWORD��6    ) %MaterialDesignFloatingHintPasswordBox#��[ 6H   $
��0 10q�6�   
�������$��18(�6�   6�   5%      5&      �� 5(   
   -   5        $��Bottom=�5(      $
��0,85q�6,   $	��150��6:   $��LOGIN��6F   6r   �� 5)   
   $��Center=�6   $��Bottom=�61   $��50q�6L   �� 5*      -   5        $��Window4.xaml?�5*      
������� � Cursor$
 Hand��6E   .�6k   NOT A MEMBER? SIGN UP!6�   5+      5,      5-      