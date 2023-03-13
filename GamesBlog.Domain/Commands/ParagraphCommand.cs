using GamesBlog.Domain.Commands.Contracts;

namespace GamesBlog.Domain.Commands
{
    public class ParagraphCommand : ICommand
    {
        public string ParagraphName { get; private set; }
        public bool IsValid { get; private set; }

        public ParagraphCommand(string paragraphName)
        {
            ParagraphName = paragraphName;
        }
    }
}
