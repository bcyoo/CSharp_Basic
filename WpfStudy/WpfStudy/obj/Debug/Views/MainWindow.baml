   M S B A M L   `   `   `  ����C  ?WpfStudy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfStudyWpfStudy  5   	   =#clr-namespace:WpfStudy.UserControlsWpfStudy.UserControls  5   	       WpfStudy.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfStudy     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   6UserControls#clr-namespace:WpfStudy.UserControls  5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 	Resources 5         	testStyle �� Property �� Value �� EndPoint �� 
StartPoint �� Opacity � Color � Offset	 �� Triggers
 �� Binding �� ElementName �� Value��%�  &	        �� 5   
   .�5      ��  � �� 5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   $	 0.3Q�6N   .��5      � $ 	#FF2733C1��6'   $ 0Q�69   � 5      $ White��6'   $ 1Q�65   � 5      $ 	#FF94E995��6'   $ 0.504Q�69   5      5      	 5      �� 5       
 6   �� *Value+$ progressBar1�� 1006R   .a�5!      ��  � y�$ Hidden=�6=   5"      5%      5&      .��5'      � .+�5(   
   �� -   5         ��Name$ 
labelTest1��5(      $��MyLabel��6$   $
��Left=�66   $��	29,19,0,0q�6Q   $	��Top=�6d   #��[  6|   �� 5)   
   -   5         ��Name$ btnTest1��5)      $��Button��6#   $��30,263,30,5q�64   $��Bottom=�6I   #��[  6�   ��6d   �� *	TestClick+��6�   �� *Text+$ textBox1��6�   �� 5*   
   -   5         ��Name$ 	CheckBox1��5*      $��나의체크박스��6&   $
��Left=�67   $��	10,84,0,0q�6R   $	��Top=�6e   	� 5+   
   $��RadioButton��6   $
��Left=�6,   $��
16,113,0,0q�6G   $	��Top=�6[    	� 	GroupName$ MyGroup��6s   	� 5,   
   $��RadioButton��6   $
��Left=�6,   $��
16,133,0,0q�6G   $	��Top=�6[   $ MyGroup��6s   	� 5-   
   $��RadioButton��6   $
��Left=�6,   $��
16,153,0,0q�6G   $	��Top=�6[   $ MyGroup��6s   �� 5.   
   -   5         ��Name$ textBox1��5.      $
��Left=�6$   $��23��6?   $��
10,188,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $��TextBox��6s   $	��Top=�6�   $	��120��6�   G� 5/   
   $
��Left=�6   $��
10,227,0,0q�61   $	��Top=�6E   $	��120��6]   �� 50   
   -   5         ��Name$ 	listView1��50      $	��128��6&   $��
168,40,0,0q�63   $	��Top=�6G   $
��Left=�6_    �� View 51      �� 52      .P�53      �� $��	이미지��6%    �� Width$	 300��62    �� CellTemplate 54      �� 55      .R�56   "   �� .+�57   &   �� $��60��6,   $��60��67   ��6C   �� *	UserImg+�� 58   &   $��20��6-   59   #   5:      5<      �� 5=      $��이름��6%    �� DisplayMemberBinding 61   �� *Name+�� 5>      $��나이��6%    61   �� *	UserAge+5?      5A      �� 5B   
   $��Label��6   $
��Left=�6    $��	37,53,0,0q�6;   $	��Top=�6N   #��[  6f   � 5C   
   -   5         �Name$ progressBar1��5C      $
��Left=�6,   $��10��6G   $��
16,272,0,0q�6S   $	��Top=�6g   $	��100��6    � Value 6�   �� *ProgressValue+)   #WpfStudy.UserControls.ThreeControls  5D   
   $
��Left=�6%   $	��100��6@   $��184,201,0,0q�6M   $	��Top=�6b      MyText$ 내가생성한라벨��6z   $	��145��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�      	MyCommand 6�   �� *	TestClick+6�     5E   
   $
��Left=�6%   $	��100��6@   $��411,201,0,0q�6M   $	��Top=�6b   $	��100��6z   #   WpfStudy.UserControls.MyLabel  5F   
   $
��Left=�6   $��625,246,0,0q�6:   $	��Top=�6O   $
��asdf��6g   �� 5G   
   $��Button��6   $
��Left=�6"   $��
635,98,0,0q�6=   $	��Top=�6Q   $��75��6i   ��6t   �� *
SecondShow+�� 5H   
   -   5        $
��Left=�5H      $��645,329,0,0q�6.   $	��Top=�6C   $	��120��6[   .@�5I      �� $��사과��6   �� 5J      $��포도��6   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5K      +  %Microsoft.Xaml.Behaviors.EventTrigger  5L         	EventName$ 
MouseLeave��6!   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5M      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction      Command  6,   �� *	TestClick+5N      5P      5Q      5R      