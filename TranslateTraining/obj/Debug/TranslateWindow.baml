   M S B A M L   `   `   `  ����L  HTranslateTraining, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TranslateTrainingTranslateTraining  5   	   '    !TranslateTraining.TranslateWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:TranslateTraining     5   	     � Title$  TranslateWindow��5   	   $	��300��6!   $	��700��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��20* �6   �� 5      $	��70* �6   �� 5      $	��20* �6    � ColumnDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��10* �6   �� 5      $	��50* �6   .+�5   
   �� $��0��6   $��0��6   $��1q�6/   ���	#FF3689CF._�5      �� -   5        $��languageFrom��5      5      �� 5   
   $��0��6   $��1��6   $��1q�6/   ���	#FF3689CF._�5      �� -   5        $��replaceLanguages��5      .��5      �� $��images/replace.jpg��6   $
��Fill=�64   5      5      �� 5   
   $��0��6   $��2��6   $��1q�6/   ���	#FF3689CF._�5      �� -   5        $��
languageTo��5      5      �� 5!   
   $��1��6   $��0��6   $��1q�6/   ���	#FF3689CF._�5"      �� -   5        $��textToTranslate��5"      5#      �� 5$   
   $��1��6   $��1��6   $��1q�6/   ���	#FF3689CF6C   �� 5%   
   $��1��6   $��2��6   $��1q�6/   ���	#FF3689CF._�5&      �� -   5        $��translatedText��5&      5'      �� 5)   
   $��2��6   $��1��6   $��1q�6/   ���	#FF3689CF._�5*      �� -   5        .��5+      �� $��images/translate.jpg��6   $
��Fill=�66   5,      5-      �� 5.   
   $��2��6   $��2��6   $��1q�6/   ���	#FF3689CF6C   50      51      