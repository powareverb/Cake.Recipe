///////////////////////////////////////////////////////////////////////////////
// HELPER METHODS
///////////////////////////////////////////////////////////////////////////////

public void SendMessageToMicrosoftTeams(string message)
{
    try
    {
        Information("Sending message to Microsoft Teams...");

        if(string.IsNullOrEmpty(BuildParameters.MicrosoftTeams.WebHookUrl)) {
            throw new InvalidOperationException("Could not resolve Microsoft Teams Web Hook Url.");
        }

        MicrosoftTeamsPostMessage(message,
            new MicrosoftTeamsSettings {
                IncomingWebhookUrl = BuildParameters.MicrosoftTeams.WebHookUrl
        });

    }
    catch(Exception ex)
    {
        Error("{0}", ex);
    }
}