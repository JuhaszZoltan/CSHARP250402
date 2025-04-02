namespace CSHARP250402;

public class Tehen : IEquatable<Tehen>
{
    public string ID { get; set; }
    public int[] Mennyisegek { get; set; }

    public void TejRogzit(string napId, int mennyiseg) =>
        Mennyisegek[int.Parse(napId)] = mennyiseg;
    public bool Equals(Tehen? other) =>
    this is not null
    && other is not null
    && this.ID == other.ID;

    public Tehen(string id)
    {
        ID = id;
        Mennyisegek = new int[7];
    }


}
