   M S B A M L   `   `   `  ����E  AWpf_doctor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Wpf_doctor
Wpf_doctor  5   	       Wpf_doctor.DoctorWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Wpf_doctor     5   	     � Title$  Doctor��5   	   $��861.574��6   $��1439.815��6)   ��5	      �� 5
   
    �� ImageSource$ img/back.jpg��6   .��5      � .+�5   
   �� -   5         ��Name$ 	listlabel��5      $��Patient List��6#   $��50��6:   $	��Top=�6F   $��330,91,958.6,0q�6^   $��20(�6v   $��Arial Black)�6�   ���	#FF126C8C6�   �� 5   
   -   5         ��Name$ listView��5      $
��Left=�6%   $	��216��6@   $	��Top=�6M   $	��409��6e   $��195,141,0,0q�6q   ���	#FFA0BCD4 �� View 5      �� 5      .P�5      �� $��Id��6%    �� DisplayMemberBinding 61   �� *Id+�� 5      $
��Name��6%    63   �� *Name+�� 5      $��Email��6%    64   �� *Email+5      5      �� 5   
   -   5         ��Name$ 
addPatient��5      $
��Left=�6%   $	��407��6@   $	��Top=�6M   $	��409��6e   $��195,390,0,0q�6q   ���	#FFA0BCD4.+�5      �� -   5        $ addlabel��5      $��Add New Patient��6&   $
��Left=�6@   $	��Top=�6[    �� Left$	 114��6s   $	��179��6�   
 �� Top$ 5��6�   $
��Bold"�6�   ���	#FF126C8C$��20(�6�   $��50��6�   �� 5      -   5        	 ��Name$	 nametxt��5      $��27��6'   
 �� TextWrapping$

 Wrap=�63   $	��176��6G   $	 206��6S   $ 60��6e   6u   �� 5       -   5         ��Name$ 	addbutton��5       $��Add Patient��6(   $	��120��6>   $	 146��6J   $	 316��6\   $��39��6�   �� 5!      -   5        $	 mailtxt��5!      $
��Left=�6'   $��25��6B   $

 Wrap=�6N   $	��Top=�6c   $	��176��6{   $	 206��6�   $	 109��6�   6�   �� 5"      $��3q�6   $	��407��6*   $	��409��67   ���	#FF126C8C6C   �� 5#      -   5        $	 unametxt��5#      $��22��6(   $

 Wrap=�64   $	��176��6H   $	 206��6T   $	 158��6f   �� 5$      -	   5        $ label2��5$      $��Patient Name: ��6$   $ 42��6=   $ 61��6N   $
��Bold"�6^   ���	#FF126C8C6p   �� 5%      -
   5        $ label3��5%      $��E-Mail: ��6$   $ 42��67   $	 109��6H   $
��Bold"�6Y   ���	#FF126C8C6k   �� 5&      -   5        $ label4��5&      $��
Username: ��6$   $ 42��69   $	 158��6J   $
��Bold"�6[   ���	#FF126C8C6m   �� 5'      -   5        $ label5��5'      $��
Password: ��6$   $ 42��69   $	 202��6J   $
��Bold"�6[   ���	#FF126C8C6m   �� 5(      -   5        $ label6��5(      $��Confirm Password: ��6$   $ 42��6A   $	 241��6R   $
��Bold"�6c   ���	#FF126C8C6u   G� 5)      -   5         G�Name$ 	passwdtxt��5)      $
��Left=�6-   $	��Top=�6H   $��21��6`   $	��176��6l    G� PasswordChar$ *��6x    G� 	MaxLength$ 8��6�   $	 206��6�   $	 206��6�   G� 5*      -   5        $ 
cpasswdtxt��5*      $
��Left=�6.   $	��Top=�6I   $��20��6a   $	��176��6m   $ 8��6y   $ *��6�   $	 206��6�   $	 246��6�   5+      �� 51   
   $
��Left=�6   $	��496��6,   $��678,141,0,0q�69   $	��Top=�6N   $	��695��6f   .+�52      �� -   5        $ label1��52      $��View Patient Profile��6$   $	 234��6C   $	 -50��6U   $��39��6f   $	��242��6r   $��Arial Black)�6~   $��20(�6�   ���	#FF126C8C6�   �� 53      ���	#FF126C8C$��3q�6-   $	��476��6A   $ 10��6N   $ 10��6_   $	��675��6o   55      �� 56      -   5         ��Name$ comboBox��56      $
��Left=�6)   $	��Top=�6D   $	��209��6\   $��24��6h   $	 250��6t   $ 37��6�   6�   �� 57      -   5        $ savebtn��57      $��Save/Modify��6&   $
��Left=�6<   $	��Top=�6W   $	��120��6o   $��19��6{   $ 64��6�   $	 387��6�   6�   �� 58      -   5        $ 	delbutton��58      $��Delete Patient��6(   $
��Left=�6A   $	��Top=�6\   $	��120��6t   $	 234��6�   $	 387��6�   6�   �� 59      -   5        $ label7��59      $��Name: ��6$   $
��Left=�65   $	��Top=�6P   $ 64��6h   $��91��6y   $��30��6�   $	 216��6�   �� 5:      -   5        $ label8��5:      $��E-Mail: ��6$   $ 64��67   $	 265��6H   �� 5;      -   5        $ label9��5;      $
��ID: ��6$   $ 64��63   $	 170��6D   �� 5<      -   5        $
	 idtb��5<      $
��Left=�6$   $��23��6?   $

 Wrap=�6K   $	��Top=�6_   $	��161��6w   $	 165��6�   $	 173��6�   {�.  6�   �� 5=      -   5        $	 nametb��5=      $
��Left=�6&   $��23��6A   $

 Wrap=�6M   $	��Top=�6a   $	��161��6y   $	 165��6�   $	 220��6�   {�.  6�   �� 5>      -   5        $	 mailtb��5>      $
��Left=�6&   $��23��6A   $

 Wrap=�6M   $	��Top=�6b   $	��161��6z   $	 165��6�   $	 267��6�   {�.  6�   �� 5?      -   5        $ label10��5?      $��Motions��6%   $
��Left=�67   $	��Top=�6R   $	 509��6j   $	 117��6|   $
��Bold"�6�   ���	#FF126C8C6�   �� 5@      $
��Left=�6   $	��190��60   $	��Top=�6=   $	��218��6U   $	 427��6a   $	 147��6s   .+�5A      �� ���	#FF126C8C$��2q�61   $	��190��6E   $	��218��6R   �� 5B      -   5         ��Name$ 
shouldercb��5B      $��Shoulder��6/   $	 122��6B   $	 145��6T   �� 5C      -   5        $ armcb��5C      $	��Arm��6*   $	 122��68   $ 86��6J   �� 5D      -   5        $ kneecb��5D      $
��Knee��6+   $ 28��6:   $ 26��6K   �� 5E      -   5        $ neckcb��5E      $
��Neck��6+   $ 28��6:   $	 145��6K   �� 5F      -   5        $ 	stretchcb��5F      $��Stretch��6.   $ 28��6@   $ 86��6Q   �� 5G      -    5        $ hipcb��5G      $	��Hip��6*   $	 122��68   $ 26��6J   5H      5I      �� 5J   
   -!   5        $ outbtn��5J      $��Logout��6!   $
��Left=�62   $��1323,10,-0.4,0q�6M   $	��Top=�6e   $	��111��6}   6�   �� 5K   
   -"   5         ��Name$ image��5K      $��img/logo.png��6   $
��Left=�65   $	��131��6P   $��847,666,0,0q�6]   $	��Top=�6r   $	��409��6�   5S      5T      