   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5          ExpenseIt.ExpenseItHome   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ExpenseIt     5        N� Title$  ExpenseIt – Home��5	      .��5      � $��
10,0,10,10q�6    � 	Resources 5   
      ExpenseDataSource � XPath � Source  nameItemTemplate �� XPath��%�   &	        &	 O     � 5      $ Expenses/Persons��68   $ Data/XMLData.xml?�6Q   5      �� 5      .R�5      �� ��6   �� $ @Name��5      5      ��5   
   �� 5       j� 
AlignmentX$
 Left=�6    j� Stretch$ UniformToFill=�6+    �� ImageSource$ /scale_1200.png��6C    j� 
AlignmentY$ Bottom=�6a   	 � ColumnDefinitions	 5   
   �� 5      $	��230 �6   �� 5      $
��Auto �6   
 � RowDefinitions
 5   
   �� 5       �� 5!      $
��Auto �6   �� 5"      �� 5#      $
��Auto �6   .+�5'   
   �� $��1��6   $��1��6!     listHeaderStyle#��[ 6.   ._�5(      ��   listHeaderTextStyle#��[ 6   .��6A   Names6H   5)      �� 5*   
   -   5        $��peopleListBox��5*      $��1��6'   $��2��67   #��[ 5,      ��5+      ��  �� Source# [  $ Person��5-      �� 51   
   -   5        $��1��51      $��3��6!     buttonStyle#��[ 6.   .��6h   View6n   �� 53   
   $��1��6     headerTextStyle#��[ 6    .��6I   View Expense Report55      56      57      