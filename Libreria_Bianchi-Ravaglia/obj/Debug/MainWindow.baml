   M S B A M L   `   `   `  ����T  PLibreria_Bianchi-Ravaglia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Libreria_Bianchi_RavagliaLibreria_Bianchi_Ravaglia  5   	   *    $Libreria_Bianchi_Ravaglia.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Libreria_Bianchi_Ravaglia     5   	     � Title$  Libreria��5   	   $��631.705��6   $	��800��6+    � 
ResizeMode$ NoResize=�67   ���	#FF7DBAFF � WindowStartupLocation$ CenterScreen=�6d   .��5	      � .+�5
   
   �� $��LIBRERIA��6   $��Center=�6#   $��299,33,270,0q�6@   $	��Top=�6V   $��48(�6n   ���	#FFFFAF7D J� RenderTransformOrigin$ 0.496,0.348&�6�   $
��Bold"�6�   $	��225��6�   �� 5   
   -   5         ��Name$ btn_CreateFile��5      $��Crea un nuovo file��6)   $
��Left=�6F   $��583,559,0,0q�6a   $	��Top=�6v   $	��176��6�   ���	#FFFFAF7D$
��Bold"�6�   ���	#FFFFAF7D
�������$��2q�6  �� 5   
   -   5        $ btn_cercaAutore��5      $��Cerca��6*   $
��Left=�6:   $��
58,191,0,0q�6U   $	��Top=�6i   $	��159��6�   $��22��6�   ���	#FFFFAF7D���	#FFFFAF7D$
��Bold"�6�   
�������$��2q�6  �� 5   
   -   5         ��Name$ 
txt_autore��5      $
��Left=�6&   $��23��6A   $��
25,163,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��225��6�   ���	#FFFFAF7D6�   �� 5   
   -   5         ��Name$ 
lst_stampa��5      $
��Left=�6&   $	��422��6A   $��279,132,0,0q�6N   $	��Top=�6c   $	��480��6{   ���	#FFFFAF7D$��2q�6�   �� 5   
   $��Inserisci titolo :
��6   $
��Left=�62   $��
25,218,0,0q�6M   $	��Top=�6a   $��27��6y   $	��118��6�   ���	#FFFFAF7D$
��Bold"�6�   �� 5   
   -   5        $ 
txt_titolo��5      $
��Left=�6&   $��23��6A   $��
25,250,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��225��6�   ���	#FFFFAF7D6�   �� 5   
   -   5        $ 	btn_copie��5      $��Numero Copie��6$   $
��Left=�6;   $��
58,278,0,0q�6V   $	��Top=�6j   $	��159��6�   $��22��6�   ���	#FFFFAF7D���	#FFFFAF7D$
��Bold"�6�   
�������$��2q�6  �� 5   
   $��Numero di romanzi:��6   $
��Left=�6-   $��
30,319,0,0q�6H   $	��Top=�6\   $��27��6t   $	��142��6�   ���	#FFFFAF7D$
��Bold"�6�   �� 5   
   -   5        $ 
btn_genere��5      $��Trova��6%   $
��Left=�65   $��172,321,0,0q�6P   $	��Top=�6e   $��78��6}   $��22��6�   ���	#FFFFAF7D���	#FFFFAF7D$
��Bold"�6�   
�������$��2q�6  �� 5   
   -   5         ��Name$ label��5      $��Inserisci un autore:
��6   $
��Left=�6H   $��
25,132,0,0q�6c   $	��Top=�6w   $��26��6�   ���	#FFFFAF7D$
��Bold"�6�   �� 5   
   -	   5        $ btn_eliminazioneAbstract��5      $��Elimina��63   $
��Left=�6E   $��172,369,0,0q�6`   $	��Top=�6u   $��78��6�   $��22��6�   
����������	#FFFFAF7D���	#FFFFAF7D$��2q�6  $
��Bold"�6!  �� 5   
   -
   5        $ label1��5      $��Elimina tag abstract:��6    $
��Left=�6@   $��
30,365,0,0q�6[   $	��Top=�6o   $
��Bold"�6�   ���	#FFFFAF7D6�   �� 5   
   $��Cambio genere:��6   $
��Left=�6)   $��
30,391,0,0q�6D   $	��Top=�6X   $	��120��6p   ���	#FFFFAF7D$
��Bold"�6�   �� 5   
   -   5        $ txt_CambioTitolo��5      $
��Left=�6,   $��26��6G   $��
58,438,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��192��6�   ���	#FFFFAF7D6�   �� 5   
   -   5        $ btn_cambio1��5      $��Cambia��6&   $
��Left=�67   $��
58,528,0,0q�6R   $	��Top=�6f   $	��159��6~   $��22��6�   ���	#FFFFAF7D���	#FFFFAF7D
�������$
��Bold"�6�   $��2q�6�   6�   �� 5   
   -   5        $ label2��5      $��Titolo��6    $
��Left=�61   $��
58,411,0,0q�6L   $	��Top=�6`   $
��Bold"�6x   ���	#FFFFAF7D6�   �� 5   
   -   5        $ label3��5      $��Nuovo genere��6    $
��Left=�67   $��
58,469,0,0q�6R   $	��Top=�6f   ���	#FFFFAF7D$
��Bold"�6�   �� 5   
   -   5        $ txt_CambioGenere��5      $
��Left=�6,   $��23��6G   $��
58,500,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��192��6�   ���	#FFFFAF7D6�   5      5      