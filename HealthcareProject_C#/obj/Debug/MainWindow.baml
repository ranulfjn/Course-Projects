   M S B A M L   `   `   `  ����L  HHealthcareProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HealthcareProjectHealthcareProject  5   	   "    HealthcareProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HealthcareProject     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0,0,0,15q�6   $��HealthCare Manager��6&   $��25(�6@   $��Center=�6N   $��Bottom=�6k   $��2��6�   $��1��6�   $��0��5      $��1��6!   �� 5   
   $��Patient Files��6   $��20(�6)   $��Center=�67   $	��Top=�6T   $��2��6l   $��2��6�   $��1��5       $��0��6!   �� 5!   
   $��Doctors ��6   $��20(�6$   $��Center=�62   $	��Top=�6O   $��2��6g   $��2��6{   $��1��5"      $��2��6!   &   System.Windows.Controls.DataGrid  5#   
   -   5        $��patientData��5#      $��	10,0,10,0q�6&   $��2��6:   $��0��6G   $��3��6W   $��2��6h      AutoGenerateColumns .     Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6'      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 65   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
fullName+ �� Mode$ OneWay=�  5&      $ HealthCare#��6%   $ * 6:    6D   �� *healthCareNumber+$ OneWay=�5(      �� 5)   
   $��10q�6   $��New Patient First Name ��6!   $��17(�6@   $��Center=�6N   $��Bottom=�6k   $��5��5*      $��0��6!   �� 5+   
   $��10q�6   $��New Patient Last Name ��6!   $��17(�6?   $��Center=�6M   $��Bottom=�6j   $��6��5,      $��0��6!   �� 5-   
   -   5        $��	firstName��5-      $��5��6#   $��1��60   $��15(�6@   $��Center=�6N   $��10q�6i   �� 5.   
   -   5        $��lastName��5.      $��6��6"   $��1��6/   $��15(�6?   $��Center=�6M   $��10q�6h   �� 5/   
   -   5        $	��add��5/      $��12(�6   $��Add New Patient��6*   $��0��6D   $��7��6T   $��10q�6a   6m   �� 50   
   -   5        $��remove��50      $��12(�6   $��Remove  Patient��6-   $��1��6G   $��7��6W   $��10q�6d   6p   �� 53   
   -   5        $��combo��53      $��2��6    $��2��6-   $��2��6=   $��1��6Q   $��
70,0,70,25q�6b   54      �� 56   
   $��10q�6   $��New Doctor First Name ��6!   $��17(�6?   $��Center=�6M   $��Bottom=�6j   $��3��57      $��2��6!   �� 58   
   $��10q�6   $��New Doctor Last Name ��6!   $��17(�6>   $��Center=�6L   $��Bottom=�6i   $��4��59      $��2��6!   �� 5:   
   -   5        $��DocFirstName��5:      $��3��6&   $��3��63   $��15(�6C   $��Center=�6Q   $��10q�6l   �� 5;   
   -   5        $��DocLastName��5;      $��4��6%   $��3��62   $��15(�6B   $��Center=�6P   $��10q�6k   �� 5<   
   -	   5        $��addDoc��5<      $��12(�6   $��Add New Doctor��6-   $��2��6F   $��5��6V   $��10q�6c   6o   �� 5=   
   -
   5        $��	removeDoc��5=      $��12(�6"   $��Remove  Doctor��60   $��3��6I   $��5��6Y   $��10q�6f   6r   �� 5?   
   -   5        $��patientToDoctor��5?      $��18(�6(   
������$��Patient Visits Doctor��6N   $��2��6n   $�� 6��6~   $��2��6�   $��10,10,10,10q�6�   6�   �� 5@   
   -   5        $��patientToPharmacy��5@      $��18(�6*   
�������$��Patient Visits Pharmacy��6K   $��2��6m   $�� 7��6}   $��2��6�   $��10,10,10,10q�6�   6�   5B      5C      