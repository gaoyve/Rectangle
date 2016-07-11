using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace Rectangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const Double RATE = 1.0; //缩放比例 默认为像素 矩形单位为像素
        private const Double defalut_stkThcns = 2.0; //默认矩形粗度

        public my_rectangle Rec = new my_rectangle();

        private Double? Length = null;
        private Double? Width = null;
        private Double? strokeThickness = null;
        private Color strokeColor = Colors.Black;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lengthBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            String inputLength = lengthBox.Text;
            if (inputLength != null) // 判断用户是否输入长度
            {
                try //尝试转换输入的字符串至Double类型
                {
                    Length = Convert.ToDouble(inputLength);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to convert '{0}' to a Double.", inputLength);
                    //MessageBox.Show("Unable to convert '{0}' to a Double.", inputLength);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("'{0}' is outside the range of a Double.", inputLength);
                    //MessageBox.Show("'{0}' is outside the range of a Double.", inputLength);
                }
            }
            
        }

        private void widthBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            String inputWidth = widthBox.Text;
            if (inputWidth != null) // 判断用户是否输入宽度
            {
                try  //尝试转换输入的字符串至Double类型
                {
                    Width = Convert.ToDouble(inputWidth);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to convert '{0}' to a Double.", inputWidth);
                    //MessageBox.Show("Unable to convert '{0}' to a Double.", inputWidth);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("'{0}' is outside the range of a Double.", inputWidth);
                    //MessageBox.Show("'{0}' is outside the range of a Double.", inputWidth);
                }
            }
        }

        private void strokeThicknessBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            String inputStrokeThickness = strokeThicknessBox.Text;
            try
            {
                strokeThickness = Convert.ToDouble(inputStrokeThickness);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", inputStrokeThickness);
                //MessageBox.Show("Unable to convert '{0}' to a Double.", inputStrokeThickness);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", inputStrokeThickness);
                //MessageBox.Show("'{0}' is outside the range of a Double.", inputStrokeThickness);
            }
        }

        private void colorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            strokeColor = colorPicker.SelectedColor ?? Colors.Black;
        }
        
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (Length == null && Width == null)
            {
                my_rectangle showRec = new my_rectangle();
                Rec.length = showRec.length * RATE; Rec.width = showRec.width * RATE;
            }
            else if (Length == null || Width == null)
            {
                Double len = Convert.ToDouble( Length ?? Width);
                my_rectangle showRec = new my_rectangle(len);
                Rec.length = showRec.length * RATE; Rec.width = showRec.width * RATE;
            }
            else if (Length != null && Width != null)
            {
                Double len = Convert.ToDouble(Length);
                Double wid = Convert.ToDouble(Width);
                my_rectangle showRec = new my_rectangle(len, wid);
                Rec.length = showRec.length * RATE; Rec.width = showRec.width * RATE;
            }

            //
            // Show The rectangle
            drawRec();
            
        }

        private void drawRec() // Draw the rectangle
        {
            ShowRecWindow showRectangleWindow = new ShowRecWindow();

            showRectangleWindow.areaBlock.Text = "Area = " + Convert.ToString(Rec.getArea());
            System.Windows.Shapes.Rectangle rect;
            rect = new System.Windows.Shapes.Rectangle();
            rect.Stroke = new SolidColorBrush(strokeColor);
            rect.Width = Rec.length;
            rect.Height = Rec.width;
            rect.StrokeThickness = strokeThickness ?? defalut_stkThcns;
            Canvas.SetLeft(rect, 0);
            Canvas.SetTop(rect, 0);
            showRectangleWindow.front_canvas.Children.Add(rect);

            showRectangleWindow.Show();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            lengthBox.Text = "";
            widthBox.Text = "";
            strokeThicknessBox.Text = "";
            colorPicker.SelectedColor = null;

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
