   M S B A M L   `   `   `  ����  MyWPFAgenda    MyWPFAgenda.login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  login��5   	   $	��300��6   $	��400��6$    � WindowStyle$ 
ToolWindow=�60    � WindowStartupLocation$ CenterScreen=�6I   .��5      � 
����  � � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   .+�5
   
   �� 
�������$��	Connexion��6'   $��Center=�68   $��Center=�6S   $��32(�6p   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $
��138* �6#   �� 5      $
��138* �6#    5      .+�5      �� -   5        $��_login��5   g   $��50��6   
�������$��Center=�67   $��	10,30,0,0q�6T   $��Login :��6u   $	��Top=�6�   $��18(�6�   �� 5      -   5        $
��_pwd��5   g   $��50��6   
�������$��Center=�67   $��	10,80,0,0q�6T   $��Mot de passe :��6s   $	��Top=�6�   $��18(�6�   �� 5      -   5        $��Login��5   a   $��1��6   $��23��6&   $��Center=�62   $��0,30,0,0q�6O   $	��Top=�6n   $	��160��6�   G� 5      -   5        $	��pwd��5   e   $��1��6   $��23��6*   $��Center=�66   $��0,80,0,0q�6S   $	��Top=�6p   $	��160��6�   �� 5      -   5        $��	connexion��5   u   $��	Connexion��6   $��1��6)   $��28��69   $��Center=�6E   $��	0,133,0,0q�6b   $	��Top=�6�   $��93��6�   5      5      5      