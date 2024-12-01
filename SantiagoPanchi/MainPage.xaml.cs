namespace SantiagoPanchi;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Método para guardar la nota
    private void OnSaveNoteClicked(object sender, EventArgs e)
    {
        var noteText = noteEditor.Text;
        if (!string.IsNullOrWhiteSpace(noteText))
        {
            // Lógica para guardar la nota
            DisplayAlert("Nota Guardada", "Tu nota ha sido guardada correctamente.", "OK");
        }
        else
        {
            DisplayAlert("Error", "Por favor, escribe una nota antes de guardar.", "OK");
        }
    }
}
