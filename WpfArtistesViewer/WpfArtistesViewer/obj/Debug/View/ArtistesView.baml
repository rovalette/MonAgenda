   M S B A M L   `   `   `  ����L  HWpfArtistesViewer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WpfArtistesViewer.ViewWpfArtistesViewer.View  5      )    #WpfArtistesViewer.View.ArtistesView   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      1my$clr-namespace:WpfArtistesViewer.View    5      $	��460��5      $	��340��6   .��5      � 
����  �  � RowDefinitions  5   
   �� 5      $��50 �6   �� 5	      �� 5
      �� 5      $��30 �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��Titre��5      $��0��6   $��3��6*   
�������$��24(�6Q   $��0,5,0,0q�6_   .��6p   Liste des artistes6�   �� 5   
   $��1��5      $��3��6   $��5,5,5,5q�5      ��5      �� *
Artistes+ �� SelectedItem 5      �� *SelectedItem+ �� View 5      �� 5      .P�5      �� $��
First Name��6%    �� DisplayMemberBinding 69   �� *	FirstName+�� 5      $��	Last Name��6%    68   �� *Name+�� 5      $��
Birth Date��6%    69   �� *BirthDateFormat+�� 5      $��
Death Date��6%    69   �� *DeathDateFormat+5      5       (   "WpfArtistesViewer.View.ArtisteView  5!   
   
����ح�$��2��60   $��3��6=    � DataContext 6Q   �� *SelectedItem+6x   �� 5"   
   -   5        $	��Add��5"      $��3��5$      $��0��6   ��5#      ��  �� Path$ 
AddCommand�.��5$   .   Add63   �� 5%   
   -   5        $��Remove��5%      $��3��5'      $��1��6   ��5&      �� $ RemoveCommand�.��5'   .   Remove66   �� 5(   
   -   5        $��Close��5(      $��3��5*      $��2��6   ��5)      �� $ CloseCommand�.��5*   .   Close65   5+      5,      