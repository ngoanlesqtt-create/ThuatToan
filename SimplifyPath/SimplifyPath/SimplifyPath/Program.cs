public class Solution
{
    public string SimplifyPath(string path)
    {
        List<string> list = new List<string>();  // Thay Stack bằng List

        string[] components = path.Split('/');

        foreach (string component in components)
        {
            if (component == "" || component == ".") continue;
            else if (component == "..")
            {
                if (list.Count > 0)
                    list.RemoveAt(list.Count - 1);
            }
            else list.Add(component);


        }

        return "/" + string.Join("/", list);
    }
}
