namespace GamesBlog.Domain.Entitties
{
    public class Title
    {
        public string TitleName { get; private set; }
        public bool IsValid { get; private set; }

        public Title(string titleName)
        {
            TitleName = titleName;
        }

        public void SetTitle(string titleName)
        {
            TitleName = titleName;
        }

        public void Validate()
        {
            if(TitleName.Length <= 0)
            {
                IsValid = false;
            }

            IsValid = true;
        }
    }
}
