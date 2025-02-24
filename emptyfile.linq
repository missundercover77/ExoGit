<Query Kind="Statements">
  <Namespace>System.Drawing</Namespace>
  <Namespace>System.Windows</Namespace>
</Query>


class Entreprise 
{
	private string NomEntreprise;
	private List<Employe> Employe;


	public Entreprise()
	{
	
	
	}
	
	public void AjouterEmploye(Employe e)
	{
		Employe.Add(e);
	}
	
	public void AfficherEmploye()
	{
	
	}
}

class Employe
{

}