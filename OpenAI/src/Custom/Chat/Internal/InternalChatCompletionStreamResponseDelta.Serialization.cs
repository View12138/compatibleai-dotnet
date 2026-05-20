using Microsoft.TypeSpec.Generator.Customizations;
using System.ClientModel.Primitives;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace OpenAI.Chat;

[CodeGenSerialization(nameof(Content), SerializationValueHook = nameof(SerializeContentValue), DeserializationValueHook = nameof(DeserializeContentValue))]
[CodeGenSerialization(nameof(ReasoningContent), SerializationValueHook = nameof(SerializeReasoningContentValue), DeserializationValueHook = nameof(DeserializeReasoningContentValue))]
internal partial class InternalChatCompletionStreamResponseDelta
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void SerializeContentValue(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        => Content.WriteTo(writer, options);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void DeserializeContentValue(JsonProperty property, ref ChatMessageContent content, ModelReaderWriterOptions options = null)
    {
        content = ChatMessageContent.DeserializeChatMessageContent(property.Value, options);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void SerializeReasoningContentValue(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        => ReasoningContent.WriteTo(writer, options);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void DeserializeReasoningContentValue(JsonProperty property, ref ChatMessageContent content, ModelReaderWriterOptions options = null)
    {
        content = ChatMessageContent.DeserializeChatMessageContent(property.Value, options);
    }
}
