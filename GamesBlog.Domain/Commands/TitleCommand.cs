using GamesBlog.Domain.Commands.Contracts;

namespace GamesBlog.Domain.Commands
{
    public class TitleCommand : ICommand
    {
        public string TitleName { get; private set; }
        public bool IsValid { get; private set; }

        public TitleCommand(string titleName)
        {
            TitleName = titleName;
        }
    }
}
