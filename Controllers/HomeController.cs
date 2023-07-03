using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        // Instancias do tipo cliente
        Cliente cliente1 = new Cliente(01,"Carlos E.","123.456.789-00","Carl.edu@gmail.com","Thor");
        Cliente cliente2 = new Cliente(02,"Mateus A.","523.456.569-10","Mateus.Alber@gmail.com","Dud");
        Cliente cliente3 = new Cliente(03,"Lucas W.","616.456.419-51","Lucas.way@gmail.com","Branco");
        Cliente cliente4 = new Cliente(04,"Maria L.","441.456.223-62","Maria.Luz@gmail.com","Preto");
        Cliente cliente5 = new Cliente(05,"Vitor R.","354.456.789-37","Vitor.Roque@gmail.com","Vlad");
        
        // Lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // Instancias do tipo Fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01,"C# PET S/A","12.456.789/0001-00","c-sharp@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02,"Ctrl Alt Dog","14.256.612/0005-02","Ctrlalt@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03,"BootsPet","37.789.152/0032-10","Boostspet@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04,"FaceAcademy","77.256.419/0001-90","Faceacademy@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05,"Maria Bolos","52.216.189/0005-55","Mariabolos@gmail.com");
      
       // Lista de Fornecedor
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
