public Text DisplayedText;
 
public void ToggleText()
{
    if (DisplayedText.enabled == true)
    {
        DisplayedText.enabled = false;
    }
    else
    {
        DisplayedText.enabled = true;
    }
}