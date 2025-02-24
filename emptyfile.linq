<Query Kind="Statements">
  <Namespace>System.Drawing</Namespace>
  <Namespace>System.Windows</Namespace>
</Query>


class Entreprise 
{
	private string _NomEntreprise;
	private List<Employe> _Employe;


	public Entreprise(string NomEntreprise, List<Employe> Employe)
	{
		this._NomEntreprise = NomEntreprise;
		this._Employe = Employe;
	
	}
	
	public void AjouterEmploye(Employe e)
	{
		_Employe.Add(e);
	}
	
	public void AfficherEmploye()
	{
		foreach(var employe in _Employe)
		{
			employe.Dump();
		}
	}
}


class Employe
{
	private string _Nom;
	private string _Prenom;
	private int _Id;
	private DateOnly _DateEmbauche;
	
	public Employe(string Nom,string Prenom,int Id,DateOnly DateEmbauche)
	{
		SetNom(Nom);
		SetPrenom(Prenom);
		SetDateEmbauche(DateEmbauche);
		SetId(Id);
	}
	
	public string GetNom()=>_Nom;
	public string GetPrenom()=>_Prenom;
	public int GetId()=>_Id;
	public DateOnly GetDateEmbauche()=>_DateEmbauche;
	
	public void SetNom(string Nom)
	{
		if(string.IsNullOrWhiteSpace(Nom))
			throw new ArgumentException();
		_Nom=Nom;
		
	}

	public void SetPrenom(string Prenom)
	{
		if (string.IsNullOrWhiteSpace(Prenom))
			throw new ArgumentException();
		_Prenom=Prenom;

	}
	public void SetId(int Id)
	{
		if(int.IsNegative(Id))
			throw new ArgumentException();
		_Id=Id;
	}
	public void SetDateEmbauche (DateOnly DateEmbauche)
	{
		_DateEmbauche=DateEmbauche;	
	}
	
	public void AfficherInfo()
	{
		($"Entreprise : ").Dump();
	}

}