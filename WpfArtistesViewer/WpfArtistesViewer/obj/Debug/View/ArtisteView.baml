   M S B A M L   `   `   `  ����  WpfArtistesViewer(    "WpfArtistesViewer.View.ArtisteView   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      $	��141��5      $	��304��6   .��5      � $��4q�6     � ColumnDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $��6 �6   �� 5	      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��5      $��0��6   $��First name:��5      $��Right=�5       �� Target 5      ��  �� ElementName$ firstNameTxt���� 5   
   -   5         ��Name$ firstNameTxt��5      $��0��5      $��2��6   ��5      ��  �� Path$ 	FirstName� �� UpdateSourceTrigger$ PropertyChanged=��� 5#   
   $��2��5$      $��0��6   $��
Last name:��5%      $��Right=�5&       5'      �� $ lastNameTxt���� 5)   
   -   5        $ lastNameTxt��5*      $��2��5+      $��2��6   ��5,      �� $
 Name�$ PropertyChanged=��� 50   
   $��4��51      $��0��6   $��Birth Date:��52      $��Right=�53       54      �� $ birthDateDtp��[<clr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkitMicrosoft.Windows.Controls 57      +  %Microsoft.Windows.Controls.DatePicker  56      Imy<clr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkit    57      -   5        $��birthDateDtp��59      $��2��58      $��4��6      SelectedDate 5:      �� $ 	BirthDate�$ PropertyChanged=��� 5>   
   $��6��5?      $��0��6   $��Death Date:��5@      $��Right=�5A       5B      �� $ deathDateDtp��[<clr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkitMicrosoft.Windows.Controls 5E        5D   
   Imy<clr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkit    5E      -   5        $��deathDateDtp��5G      $��2��5F      $��6��6    5H      �� $ 	DeathDate�$ PropertyChanged=�5J      5K      