namespace Domain.Entidades;
using Domain.Interface;
public class Url : InterfaceEntidadeBase
{
    public Guid Id {get; set;} = new Guid (); 
    public required string Link { get; set; }
    public bool Eantissrf {get; set;}
    public bool EPossivelMalware {get; set;}
    public bool EImpropio {get; set;}
    public bool Eexistente {get; set;}
    public RotaPersonalizada RotaPersonalizadaCorrespondente { get; set; }

}