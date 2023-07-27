namespace GridLife.src
{
    public static class MessageStorage
    {
        const string continueKey = "\n\nPress Enter to continue...";
        public static int index = 0;
        public static string[] messages =
        {
            "Welcome to Grid Life." + continueKey,
            "Select tiles by pressing numeric keys." + continueKey,
            "Press Shift + Q to exit." + continueKey
        };

        public static void SetNextMessage(ref Label label)
        {
            if (index < messages.Length)
            {
                label.Text = messages[index++];
            }
            else
            {
                label.Hide();
            }
        }
    }
}
