namespace VerifyMSTest;

partial class VerifyBase
{
#pragma warning disable CA1822 // Mark members as static
#if NET6_0_OR_GREATER

    /// <summary>
    /// Verifies the contents of <paramref name="path" />.
    /// </summary>
    [Pure]
    public SettingsTask VerifyDirectory(
        string path,
        Func<string, bool>? include = null,
        string? pattern = null,
        EnumerationOptions? options = null,
        VerifySettings? settings = null,
        object? info = null,
        FileScrubber? fileScrubber = null,
        [CallerFilePath] string sourceFile = "") =>
        Verifier.VerifyDirectory(path, include, pattern, options, settings, info, fileScrubber, sourceFile);

    /// <summary>
    /// Verifies the contents of <paramref name="path" />.
    /// Differs from passing <see cref="DirectoryInfo" /> to <code>Verify(object? target)</code> which will verify the full path.
    /// </summary>
    [Pure]
    public SettingsTask VerifyDirectory(
        DirectoryInfo path,
        Func<string, bool>? include = null,
        string? pattern = null,
        EnumerationOptions? options = null,
        VerifySettings? settings = null,
        object? info = null,
        FileScrubber? fileScrubber = null,
        [CallerFilePath] string sourceFile = "") =>
        Verifier.VerifyDirectory(path, include, pattern, options, settings, info, fileScrubber, sourceFile);
#else
    /// <summary>
    /// Verifies the contents of <paramref name="path"/>.
    /// </summary>
    [Pure]
    public SettingsTask VerifyDirectory(
        string path,
        Func<string, bool>? include = null,
        string? pattern = null,
        SearchOption option = SearchOption.AllDirectories,
        VerifySettings? settings = null,
        object? info = null,
        FileScrubber? fileScrubber = null,
        [CallerFilePath] string sourceFile = "") =>
        Verifier.VerifyDirectory(path, include, pattern, option, settings, info, fileScrubber, sourceFile);

    /// <summary>
    /// Verifies the contents of <paramref name="path"/>.
    /// Differs from passing <see cref="DirectoryInfo"/> to <code>Verify(object? target)</code> which will verify the full path.
    /// </summary>
    [Pure]
    public SettingsTask VerifyDirectory(
        DirectoryInfo path,
        Func<string, bool>? include = null,
        string? pattern = null,
        SearchOption option = SearchOption.AllDirectories,
        VerifySettings? settings = null,
        object? info = null,
        FileScrubber? fileScrubber = null,
        [CallerFilePath] string sourceFile = "") =>
        Verifier.VerifyDirectory(path, include, pattern, option, settings, info, fileScrubber, sourceFile);
#endif
}