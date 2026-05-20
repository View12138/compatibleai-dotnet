using Microsoft.TypeSpec.Generator.Customizations;

namespace OpenAI.Chat;

[CodeGenVisibility(nameof(ChatThinkingOptions), CodeGenVisibility.Internal)]
public partial class ChatThinkingOptions
{
    [CodeGenMember("Type")]
    public ChatThinkingType? Type { get; set; }
}