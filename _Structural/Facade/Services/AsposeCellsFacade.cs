namespace Facade.Services;

using Aspose.Cells;

// is Facade for 'Aspose.Cells' library
public class AsposeCellsFacade {
    public void CreateExcel<TEntity>(string filename, IEnumerable<TEntity> entities) {
        // create xls file
        var destPath = @$"{filename}.xlsx";
        using var stream = File.Create(destPath);

        // fill excel
        var workbook = new Workbook(stream);
        var rows = workbook.Worksheets[0].Cells.Rows;

        // fill column names
        var props = typeof(TEntity).GetProperties();
        for (int i = 0; i < props.Length; i++)
            rows[0][i].PutValue(props[i].Name);

        // fill values of entities
        for (int elIndex = 0; elIndex < entities.Count(); elIndex++)
            for (int propIndex = 0; propIndex < props.Length; propIndex++)
                rows[elIndex + 1][propIndex].PutValue(props[propIndex].GetValue(entities.ElementAt(elIndex)));

        // save
        workbook.Save(stream, SaveFormat.Xlsx);
    }
}