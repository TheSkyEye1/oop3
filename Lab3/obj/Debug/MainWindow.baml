   M S B A M L   `   `   `  ����?  ;Lab3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab3Lab3  5   	   c _GMap.NET.WindowsPresentation, Version=1.9.8.0, Culture=neutral, PublicKeyToken=b85b9027b614afefqPclr-namespace:GMap.NET.WindowsPresentation;assembly=GMap.NET.WindowsPresentationGMap.NET.WindowsPresentation 5   	       Lab3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab3     5   	   pWindowsPresentationPclr-namespace:GMap.NET.WindowsPresentation;assembly=GMap.NET.WindowsPresentation     5   	     � Title$  
MainWindow��5	   	   $��549.667��6   $
��1000��6-   .��5
      � .+�5   
   � -   5        $
��Maps��5      $
��Auto��6   $
��Auto��6)   $��	250,5,5,5q�66   .+�5      .  (GMap.NET.WindowsPresentation.GMapControl  -   5        $	��Map��5   .   6z   5      �� 5   
   -   5         ��Name$ combox��5      $
��Left=�6#   $��	10,10,0,0q�6>   $	��Top=�6Q   $	��220��6i   .@�5      �� .��6   point6"   �� 5      .��6   car6    �� 5      .��6   people6#   �� 5      .��6   route6"   �� 5      .��6   area6!   5      �� 5   
   -   5         ��Name$ OName��5      $
��Left=�6!   $��25��6<   $��
10,219,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��220��6�   �� 5   
   -   5         ��Name$ OList��5      $
��Left=�6!   $	��160��6<   $��
10,354,0,0q�6I   $	��Top=�6]   $	��220��6u    �� SelectedIndex$ 0��6�   .@�5      �� 5      �� 5   
   -   5         ��Name$ createra��5      $��OK��6#   $
��Left=�60   $��26��6K   $��100,188,0,0q�6W   $	��Top=�6l   $	��130��6�   {�.  6�   	� 5   
   -   5         	�Name$ createrb��5      $��creation mode��6(   $
��Left=�6@   $��
10,249,0,0q�6[   $	��Top=�6o   $��19��6�   $��96��6�    J� RenderTransformOrigin$ 0.479,1.842&�6�   	� 5   
   -   5        $ findrb��5      $��find nearest��6&   $
��Left=�6=   $��
10,273,0,0q�6X   $	��Top=�6l   $ 0.659,4.067&�6�   �� 5    
   $��Name's here:��6   $
��Left=�6'   $��
10,188,0,0q�6B   $	��Top=�6V   $��85��6n   $ 	0.483,0.5&�6y   �� 5!   
   -	   5        $ objfind��5!      $
��Left=�6#   $��25��6>   $��
10,324,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��220��6�   {�.  6�   �� 5"   
   $��Name's here:��6   $
��Left=�6'   $��
10,293,0,0q�6B   $	��Top=�6V   $��85��6n   $ 	0.483,0.5&�6y   �� 5#   
   -
   5        $ finder��5#      $
��FIND��6!   $
��Left=�60   $��26��6K   $��100,293,0,0q�6W   $	��Top=�6l   $	��130��6�   {�.  6�   �� 5$   
   -   5        $ clearpoints��5$      $��CLEAR POINTS��6&   $
��Left=�6=   $��26��6X   $��100,157,0,0q�6d   $	��Top=�6y   $	��130��6�   {�.  6�   5%      5&      