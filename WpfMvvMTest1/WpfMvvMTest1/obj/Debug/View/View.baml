   M S B A M L   `   `   `  ����G  CWpfMvvMTest1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfMvvMTest1.ViewWpfMvvMTest1.View  5   	   ?$clr-namespace:WpfMvvMTest1.ViewModelWpfMvvMTest1.ViewModel  5   	       WpfMvvMTest1.View.View   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WpfMvvMTest1.View     5   	   3vm$clr-namespace:WpfMvvMTest1.ViewModel     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$
 MVVM��5
   	   $	��450��6   $	��700��6#    � DataContext 5      &   WpfMvvMTest1.ViewModel.ViewModel  5   
   6   .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   .+�5      �� $	��200��6-   $��10q�69   
�������$��0��6]   ��6   �� *Input+6l   �� 5      $	��200��6.   $��10q�6:   
�������$��1��6^   ��6   �� *Output+6m   �� 5      $��10q�64   $	��200��6@   ��6   �� *
ChangeText+.��6L   Change Text6Y   5      �� 5   
   $��3��6   $ 
Horizontal=�6"   .+�5      �� $��2q�6   $��30��6    .��6,   ГРИДА ТЕСТ:6:   �� 5      
�������$	��200��6A   $��
158,0,0,10q�6M   ��6   �� *Number+6M   �� 5      $	��200��62   $��20 5 5 5q�6>   $
��open��6P   ��6   �� *
OpenWin1+6P   5      5      5       