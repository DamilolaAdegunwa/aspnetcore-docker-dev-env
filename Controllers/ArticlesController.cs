using Microsoft.AspNetCore.Mvc;

[Route("/api/[controller]")]
public class ArticlesController
{
  [HttpGet]
  public string Get() => "Hello, from the controller. I'm being watched!!!! And I'm in a container deployed in the cloud!";
}