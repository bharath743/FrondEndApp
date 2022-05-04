
namespace FrontEnd.BlazorWasm.Services.Interfaces
{
    public interface IPdfExportationService
    {
        void ExportPdf<T>(IEnumerable<T> data, string docTitle, string comments, string mTitle);
        ValueTask<object> SaveAs(string filename, byte[] data);
        ValueTask<object> SaveAs(string filename, string base64File);
    }
}