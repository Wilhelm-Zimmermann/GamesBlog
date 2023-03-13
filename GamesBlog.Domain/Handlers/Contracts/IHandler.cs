using GamesBlog.Domain.Commands;
using GamesBlog.Domain.Commands.Contracts;

namespace GamesBlog.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        Task<ICommandResult> Handle(T command);
    }
}
