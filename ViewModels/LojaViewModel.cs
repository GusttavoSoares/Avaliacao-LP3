namespace Avaliacao3BimLP3.ViewModels;

public class LojaViewModel
{
    public int Id { get; set; }
    public string Piso { get; set; }
    public string Nome { get; set; }   
    public string Descricao { get; set; }
    public bool IsLoja { get; set; }
    public string Email  { get; set; }

    public LojaViewModel(int id, string piso, string nome, string descricao, bool isLoja, string email)
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Descricao = descricao;
        IsLoja = isLoja;
        Email = email;
    }

    public LojaViewModel(){}
}