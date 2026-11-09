using Domain.Interface;

namespace Domain.Entidades;
public class RotaPersonalizada : InterfaceEntidadeBase
{
    public Guid IdRotaPersonalizada {get; set;} = new Guid();
    public string NomePersonalizadoRota {get; set;} = Guid.NewGuid().ToString("N")[..8];
    public int contagemDeAcessos { get; set; }
}

