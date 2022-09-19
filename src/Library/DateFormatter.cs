namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        date = date.Trim();
        string formatoDemo = $"La cadena ingresada: '{date}' no tiene un formato: 'dd/mm/yyyy'.";
        if (date.Length != 10)
        {
            Console.WriteLine(formatoDemo);
            return formatoDemo;
        }
        try
        {
            int days = Int32.Parse(date.Substring(0,2));
            int month = Int32.Parse(date.Substring(3,2));
            int year = Int32.Parse(date.Substring(6));
            bool validData = DateAnalyse.ValidDate(days, month, year);
            if (validData == true)
                return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
            Console.WriteLine(formatoDemo);
            return formatoDemo;
        }
        catch (FormatException)
        {
            Console.WriteLine(formatoDemo);
            return formatoDemo;
        } 
    }
}
