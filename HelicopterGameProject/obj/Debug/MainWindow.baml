   M S B A M L   `   `   `  ����P  LHelicopterGameProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:HelicopterGameProjectHelicopterGameProject  5   	   &     HelicopterGameProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:HelicopterGameProject     5   	   -   5          �Name$  MainWindow1��5   	    � Title$ Helicopter Game Project��5   	   $	��450��6)   $	��800��66   .��5
      � ���	#FF191919 � RowDefinitions 5   
   �� 5      $��9* �6   �� 5      $
��131* �6   .+�5   
   �� $��
0,0,-0.4,0q�6   $��2��6%   .+�5      �� -   5         ��Name$ 	TitleRect��5      ���	#FF38DA17$
��Left=�6<   $��34��6W   
�������$	��Top=�6r   $	��794��6�   $��	0,0,0.4,0q�6�   �� 5      -   5         ��Name$ Title��5      $/��)Enjoy the game and Remember the childhood��6#   $
��Left=�6W   $��	367,0,0,0q�6r   $	��Top=�6�   $��20(�6�   $��Trebuchet MS)�6�   �� 5      -   5        $ 	CalcuRect��5      ���	#FF38DA17$
��Left=�6<   $��47��6W   
�������$	��Top=�6r   $	��794��6�   $��0,373,0.4,0q�6�   �� 5      -   5        $ Distance��5      $��	 survive:��6&   $
��Left=�6:   $��
10,380,0,0q�6U   $	��Top=�6i   $��Trebuchet MS)�6�   $��18(�6�   $
��Bold"�6�   �� 5      -   5        $ DistanceResult��5      $��0��6,   $
��Left=�68   $��
93,380,0,0q�6S   $	��Top=�6g    J� RenderTransformOrigin$ 0.167,-0.769&�6   $��18(�6�   $��Trebuchet MS)�6�   �� 5      -   5        $ 
ScoreTitle��5      $��Best Score:��6(   $
��Left=�6>   $��644,380,0,0q�6Y   $	��Top=�6n   $��Trebuchet MS)�6�   $��18(�6�   $
��Bold"�6�   �� 5      -   5        $ ScoreResult��5      $��0��6)   $
��Left=�65   $��749,380,0,0q�6P   $	��Top=�6e   $ 0.167,-0.769&�6}   $��18(�6�   $��Trebuchet MS)�6�   �� 5      $
��Left=�6   $	��100��64   $��-339,-55,0,0q�6A   $	��Top=�6W   $	��100��6o   �� 5      -	   5        $ Pillar1��5      ���	#FF38DA17$
��Left=�6:   $	��100��6U   
�������$	��Top=�6q   $��30��6�    �� Left$	 471��6�   
 �� Top$ 34��6�   �� 5      -
   5        $ Pillar2��5      ���	#FF38DA17$
��Left=�6:   $	��100��6U   
�������$	��Top=�6q   $��30��6�   $ 1.128,0.518&�6�   $	 672��6�   $	 148��6�   �� 5      -   5        $ Pillar3��5      ���	#FF38DA17$
��Left=�6:   $	��100��6U   
�������$	��Top=�6q   $��30��6�   $	 274��6�   $	 148��6�   �� 5      -   5         ��Name$ image1��5      $	��100��6$   $	 534��61   $	 127��6C   $	��100��6T   �� 5      -   5        $ Pillar4��5      ���	#FF38DA17$
��Left=�6:   $	��100��6U   
�������$	��Top=�6q   $��30��6�   $ 1.128,0.518&�6�   $	 471��6�   $	 274��6�   �� 5      -   5        $ RectHeli��5      $��42��6*   
�������$	 169��6E   $��49��6V   $ 44��6a   ��5      �� 5      	 �� ImageSource$�	 �C:\Users\Dipak Mukesh\OneDrive - Sparta Global Limited\Engineering40\SpartaProject\HelicopterGameProject\HelicopterGameProject\Resources\Helicopter.png��6!   5!      5"      5#      5$      