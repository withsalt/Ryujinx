using Ryujinx.Common.Utilities;
using System.Text.Json.Serialization;

namespace Ryujinx.HLE.Audio
{
    [JsonConverter(typeof(TypedStringEnumConverter<AudioBackend>))]
    public enum AudioBackend
    {
        Dummy,
        OpenAl,
        SoundIo,
        SDL2,
    }
}
