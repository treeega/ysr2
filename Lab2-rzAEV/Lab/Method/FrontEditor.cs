using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace Lab.Method
{
  //  public class FontEditor
  //  {
  //      public FontEditor(Page page)
  //      {
  //          AimPage = page;
  //      }
  //      Page AimPage { get; set; }
  //      List<TextBox> allTextBoxes = new List<TextBox>();
  //      List<TextBlock> allTextBlocks = new List<TextBlock>();
  //      List<ComboBox> allComboBoxs = new List<ComboBox>();
  //      List<RichTextBox> allRichTextBoxs = new List<RichTextBox>();
  //      //List<Label> allLabels = new List<Label>();
  //      List<DataGrid> allDataGrids = new List<DataGrid>();
  //      string path = "FontParametrs.txt";
  //      public string FontName { get; set; } //Название шрифта
  //      public int FontSize { get; set; } //Размер шрифта
  //      private string fontDemo { get; set; } //В каком виде шрифт хранится в файле

  //      //Считать шрифт из папки
  //      private void ReadFont()
  //      {

  //          try
  //          {
  //              using (StreamReader sr = new StreamReader(path))
  //              {
  //                  fontDemo = sr.ReadToEnd();
  //              }
  //          }
  //          catch (Exception ex)
  //          {
  //              fontDemo = "Segoe UI" + "=" + 25.ToString();
  //              WriteFont();
  //              ReadFont();
  //              MessageBox.Show(ex.Message);
  //          }
  //      }

  //      //Записать шрифт в папку
  //      private void WriteFont()
  //      {
  //          try
  //          {
  //              using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
  //              {
  //                  sw.WriteLine(fontDemo);
  //              }
  //          }
  //          catch (Exception ex)
  //          {
  //              MessageBox.Show(ex.Message);
  //          }
  //      }

  //      //Создать новый шрифт
  //      public void Create(String fontName, int fontSize)
  //      {
  //          fontDemo = fontName + "=" + fontSize.ToString();
  //          WriteFont();
  //      }

  //      Открыть и применить новый шрифт
  //      public void Open()
  //      {
  //          ReadFont();
  //          string[] fonts = fontDemo.Split('=');
  //          FontName = fonts[0];
  //          FontSize = int.Parse(fonts[1].Split('\\')[0]);
  //          SetUpdates();
  //      }

  //      private void SetUpdates()
  //      {

  //          FindChildren(allTextBoxes, AimPage);
  //          FindChildren(allTextBlocks, AimPage);
  //          FindChildren(allComboBoxs, AimPage);
  //          FindChildren(allRichTextBoxs, AimPage);
  //          FindChildren(allDataGrids, AimPage);
  //          for (int i = 0; i < allTextBoxes.Count; i++)
  //          {
  //              allTextBoxes[i].FontSize = FontSize;
  //              allTextBoxes[i].FontFamily = new FontFamily(FontName);
  //          }
  //          for (int i = 0; i < allTextBlocks.Count; i++)
  //          {
  //              allTextBlocks[i].FontSize = FontSize;
  //              allTextBlocks[i].FontFamily = new FontFamily(FontName);
  //          }
  //          for (int i = 0; i < allComboBoxs.Count; i++)
  //          {
  //              allComboBoxs[i].FontSize = FontSize;
  //              allComboBoxs[i].FontFamily = new FontFamily(FontName);
  //          }
  //          for (int i = 0; i < allRichTextBoxs.Count; i++)
  //          {
  //              allRichTextBoxs[i].FontSize = FontSize;
  //              allRichTextBoxs[i].FontFamily = new FontFamily(FontName);
  //          }
  //          for (int i = 0; i < allDataGrids.Count; i++)
  //          {
  //              allDataGrids[i].FontSize = FontSize;
  //              allDataGrids[i].FontFamily = new FontFamily(FontName);
  //          }
  //      }

  //      internal static void FindChildren<T>(List<T> results, DependencyObject startNode)
  //where T : DependencyObject
  //      {
  //          int count = VisualTreeHelper.GetChildrenCount(startNode);
  //          for (int i = 0; i < count; i++)
  //          {
  //              DependencyObject current = VisualTreeHelper.GetChild(startNode, i);
  //              if ((current.GetType()).Equals(typeof(T)) || (current.GetType().GetTypeInfo().IsSubclassOf(typeof(T))))
  //              {
  //                  T asType = (T)current;
  //                  results.Add(asType);
  //              }
  //              FindChildren<T>(results, current);
  //          }
  //      }//Поиск всех элементов управления на странице

  //  }
}
