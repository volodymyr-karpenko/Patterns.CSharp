using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Patterns.CSharp.Models;
using Patterns.CSharp.Patterns;
using System.Threading.Tasks;

namespace Patterns.CSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatternsController : ControllerBase
    {
        private readonly ILogger<PatternsController> _logger;

        public PatternsController(ILogger<PatternsController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("GetOutput")]
        public async Task<ActionResult<string>> GetOutput([FromBody] PatternTypeModel body)
        {
            PatternTypeModel pattern = new PatternTypeModel
            {
                patternType = body.patternType
            };

            PatternUseCase useCase = null;

            await Task.Factory.StartNew(() => {               

                switch (pattern.patternType)
                {
                    case "AbstractFactory":
                        useCase = new Patterns.AbstractFactory.UseCase();
                        break;
                    case "Adapter":
                        useCase = new Patterns.Adapter.UseCase();
                        break;
                    case "Bridge":
                        useCase = new Patterns.Bridge.UseCase();
                        break;
                    case "Builder":
                        useCase = new Patterns.Builder.UseCase();
                        break;
                    case "ChainOfResponsibility":
                        useCase = new Patterns.ChainOfResponsibility.UseCase();
                        break;
                    case "Command":
                        useCase = new Patterns.Command.UseCase();
                        break;
                    case "Composite":
                        useCase = new Patterns.Composite.UseCase();
                        break;
                    case "Decorator":
                        useCase = new Patterns.Decorator.UseCase();
                        break;
                    case "Facade":
                        useCase = new Patterns.Facade.UseCase();
                        break;
                    case "FactoryMethod":
                        useCase = new Patterns.FactoryMethod.UseCase();
                        break;
                    case "Flyweight":
                        useCase = new Patterns.Flyweight.UseCase();
                        break;
                    case "Interpreter":
                        useCase = new Patterns.Interpreter.UseCase();
                        break;
                    case "Iterator":
                        useCase = new Patterns.Iterator.UseCase();
                        break;
                    case "Mediator":
                        useCase = new Patterns.Mediator.UseCase();
                        break;
                    case "Memento":
                        useCase = new Patterns.Memento.UseCase();
                        break;
                    case "Observer":
                        useCase = new Patterns.Observer.UseCase();
                        break;
                    case "Prototype":
                        useCase = new Patterns.Prototype.UseCase();
                        break;
                    case "Proxy":
                        useCase = new Patterns.Proxy.UseCase();
                        break;
                    case "Singleton":
                        useCase = new Patterns.Singleton.UseCase();
                        break;
                    case "State":
                        useCase = new Patterns.State.UseCase();
                        break;
                    case "Strategy":
                        useCase = new Patterns.Strategy.UseCase();
                        break;
                    case "TemplateMethod":
                        useCase = new Patterns.TemplateMethod.UseCase();
                        break;
                    case "Visitor":
                        useCase = new Patterns.Visitor.UseCase();
                        break;
                }
            });

            if (useCase == null)
            {
                return "";
            }

            return useCase.GetOutput();
        }
    }
}