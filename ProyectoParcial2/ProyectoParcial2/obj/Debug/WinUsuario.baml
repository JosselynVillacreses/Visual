   M S B A M L   `   `   `  ����  ProyectoParcial2!    ProyectoParcial2.WinUsuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          � Title$  
WinUsuario��5      $��785.2��6   $��902.5��6'   ���	#FFA4A4A4.��5      � $��	0,0,0,120q�6   $	��634��6   $��Bottom=�6+    � ColumnDefinitions 5   
   �� 5      .+�5	   
   �� $
��Left=�6   $��20��6-   $��
698,59,0,0q�69    �� TextWrapping$
 Wrap=�6M   $��Buscar��6a   $	��Top=�6o   $	��144��6�   ���	#FFA4A4A4���	#FF00C5FF$��Consolas)�6�   �� 5
   
   $�� ��6   $
��Left=�6   $��
842,59,0,0q�67   $	��Top=�6K   $��26��6c   ���	#FF00C5FF���	#FFA4A4A4��5      �� 5       �� ImageSource$ images/search.png��6    j� Stretch$ Uniform=�6=   5      o� 5   
   $��24��6   $	��Top=�6   $��Center=�61   $��Center=�6M   ���	#FF00C5FF���	#FFB9B9B9$��10,10,804,600q�6�   $��80��6�   ��6m   Z� .@�5      m� -   5        $
��Menu��5      $��24��6%   $	��151��61   ���	#FFECECEC.@�5      m� -   5        $��Crear...��5      ���	#FF4646466D   m� 5      -   5        $��Eliminar...��5      ���	#FF4646466G   5      5      �� 5   
   -   5         ��Name$ lblUser��5      $ ��Bienvenid@ WillitoPexoxo94��6!   $
��Left=�6F   $��
577,10,0,0q�6a   $	��Top=�6u   $��Consolas)�6�   $��11(�6�   ���	#FFECECEC��6�   Z� �� 5   
   -   5        $��Cerrar Sesión��5      $
��Left=�6)   $��
779,10,0,0q�6D   $	��Top=�6X   ���	#FF00C5FF$��Consolas)�6�   $��11(�6�   6�   �� 5   
    K� ZIndex$ -1��6   $�� ��6"   $
��Left=�6-   $��42��6H   $	��Top=�6T   $	��894��6l   ���	#FF464646$��0,-3,0,0q�6�   �� 5   
   -   5         ��Name$ 
btnComprar��5      $�� ��6%   $
��Left=�60   $��	20,47,0,0q�6K   $	��Top=�6^   $��38��6v   ���	#FFA4A4A4$��41��6�   ��6�   Z� ��5       �� 5!      $ Uniform=�6   $ images/compras.png��6/   5#      �� 5%   
   -   5        $ 
btnFactura��5%      $��Mostrar Factura��6%   $
��Left=�6?   $��
216,53,0,0q�6Z   $	��Top=�6n   $��94��6�   ���	#FF8B8B8B$��30��6�   ���	#FF3399FF���	#FFF4FDFF5'      �� 5)   
   -	   5         ��Name$ txtxNumCompra��5)      $
��Left=�6)   $��20��6D   $��	74,59,0,0q�6P   $��0 ��6c   $	��Top=�6m   $��82��6�   ���	#FF979696���	#FF00C5FF$��Consolas)�6�   $��Center=�6�   $��Center=�6�   $��10.667(�63  ��6  Z� 63  &   System.Windows.Controls.DataGrid  5+   
   -
   5        	  Name$	 dgDescripcionVideojuegos��5+      $��
34,0,62,67q�65   $��Bottom=�6I   $	��421��6d   $	��798��6q   
   AutoGenerateColumns
 .  $��Center=�6�      
IsReadOnly .    CanUserAddRows .  ��6�   �� *Juegos+   Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$ Titulo��6c      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *titulo+   ClipboardContentBinding 6@   Z� 6s     5.      $ TituloOriginal��6k    .  6%   �� *tituloOriginal+ 6H   Z� 6�     5/      $ Desarrollador��6j    .  6%   �� *desarrollador+ 6G   Z� 6�     50      $ Distribuidor��6i    .  6%   �� *distribuidor+ 6F   Z� 6     51      $ 
Diseñador��6f    .  6%   �� *
diseñador+ 6C   Z� 6y     52      $ Programador��6h    .  6%   �� *programador+ 6E   Z� 6}     53      $ Lanzamiento��6h    .  6%   �� *lanzamiento+ 6E   Z� 6}     54      $ 
Plataforma��6g    .  6%   �� *
plataforma+ 6D   Z� 6{     55      $ Genero��6c    .  6%   �� *genero+ 6@   Z� 6s     56      $
 Modo��6a    .  6%   �� *modo+ 6>   Z� 6o     57      $ Precio��6c    .  6%   �� *precio+ 6@   Z� 6s     58      $ 	Avaliable��6f    .  6%   �� *	avaliable+ 6C   Z� 6y     59      $ Stock��6b    .  6%   �� *stock+ 6?   Z� 6q   5>      5B      5C      