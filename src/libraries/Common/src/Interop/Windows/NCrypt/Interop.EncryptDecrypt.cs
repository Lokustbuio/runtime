// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal static partial class Interop
{
    internal static partial class NCrypt
    {
        internal static unsafe ErrorCode NCryptEncrypt(SafeNCryptKeyHandle hKey, ReadOnlySpan<byte> pbInput, int cbInput, void* pPaddingInfo, Span<byte> pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags) =>
            NCryptEncrypt(hKey, ref MemoryMarshal.GetReference(pbInput), cbInput, pPaddingInfo, ref MemoryMarshal.GetReference(pbOutput), cbOutput, out pcbResult, dwFlags);

        [GeneratedDllImport(Interop.Libraries.NCrypt)]
        private static unsafe partial ErrorCode NCryptEncrypt(SafeNCryptKeyHandle hKey, ref byte pbInput, int cbInput, void* pPaddingInfo, ref byte pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags);

        internal static unsafe ErrorCode NCryptDecrypt(SafeNCryptKeyHandle hKey, ReadOnlySpan<byte> pbInput, int cbInput, void* pPaddingInfo, Span<byte> pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags) =>
            NCryptDecrypt(hKey, ref MemoryMarshal.GetReference(pbInput), cbInput, pPaddingInfo, ref MemoryMarshal.GetReference(pbOutput), cbOutput, out pcbResult, dwFlags);

        [GeneratedDllImport(Interop.Libraries.NCrypt)]
        private static unsafe partial ErrorCode NCryptDecrypt(SafeNCryptKeyHandle hKey, ref byte pbInput, int cbInput, void* pPaddingInfo, ref byte pbOutput, int cbOutput, out int pcbResult, AsymmetricPaddingMode dwFlags);
    }
}
