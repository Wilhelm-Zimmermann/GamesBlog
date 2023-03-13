namespace GamesBlog.Domain.Entities
{
    public class Paragraph
    {
        public string ParagraphName { get; private set; }
        public bool IsValid { get; private set; }

        public Paragraph(string paragraphName)
        {
            ParagraphName = paragraphName;
        }

        public void SetParagraph(string paragraphName)
        {
            ParagraphName = paragraphName;
        }

        public void Validate()
        {
            if(ParagraphName.Length <= 0)
            {
                IsValid = false;
            }

            IsValid = true;
        }
    }
}
