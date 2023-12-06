namespace AG_appApuntes.Views;

public partial class AG_CountPage : ContentPage
{
	public AG_CountPage()
	{
		InitializeComponent();
		BindingContext = new Models.Count();

	}

    private void AGCalcular_Clicked(object sender, EventArgs e)
    {
        
        Models.Count countInstance = (Models.Count)BindingContext;

        
        string texto = countInstance.Text; 

        // Calcular las propiedades
        countInstance.Letras = texto.Length;
        countInstance.numeros = texto.Count(char.IsDigit);
        countInstance.mayus = texto.Count(char.IsUpper);
        countInstance.minus = texto.Count(char.IsLower);
        countInstance.vocales = texto.Count(c => "aeiouAEIOU".Contains(c));
        countInstance.total = countInstance.Letras + countInstance.numeros + countInstance.mayus + countInstance.minus + countInstance.vocales;
    }

    private void AGLimpiar_Clicked(object sender, EventArgs e)
    {
        // Acceder al contexto de datos (instancia de la clase Count)
        Models.Count countInstance = (Models.Count)BindingContext;

        // Limpiar las propiedades
        countInstance.Text = ""; // Limpiar el texto del Editor
        countInstance.Letras = 0;
        countInstance.numeros = 0;
        countInstance.mayus = 0;
        countInstance.minus = 0;
        countInstance.vocales = 0;
        countInstance.total = 0;
    }

   
}