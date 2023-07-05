using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
	class CSVExport
	{
		public void export(Project.ModelDataSet.PodaciDataTable podaci, out string odgovor)
		{ 
			odgovor = String.Empty; 
			using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
			{
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						using (XLWorkbook workbook = new XLWorkbook())
						{
							ModelDataSet modelDataSet = new ModelDataSet();
							workbook.Worksheets.Add(podaci.CopyToDataTable(), "Tablica"); 
							workbook.SaveAs(saveFileDialog.FileName); 
						}
						odgovor = "Podaci su uspješno spremljeni!"; 
					}
					catch (Exception ex)
					{
						odgovor = "Neuspješan pokušaj spremanja!";
					}
				}
			}
		}
	}
}
