using System.Collections.Generic;
using HondaWmiApi.Models;

public interface IHondaWmiService{
    List<HondaWmiModel> GetList();
}