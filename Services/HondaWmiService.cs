using System.Collections.Generic;
using System.Text.Json;
using HondaWmiApi.Models;

public class HondaWmiService : IHondaWmiService
{
    private readonly List<HondaWmiModel> hondaWmiList;
    public HondaWmiService(){
        var jsonString = System.IO.File.ReadAllText("Data/honda_wmi.json");
        hondaWmiList = JsonSerializer.Deserialize<List<HondaWmiModel>>(jsonString);
    }
    public List<HondaWmiModel> GetList()
    {
        return hondaWmiList;
    }
}