using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using ReactiveUI;
using Splat;

namespace Pradana.ReactiveUI.Commons
{
    public class AppCenterLogger : IFullLogger
    {
        public LogLevel Level => LogLevel.Error;

        public bool IsDebugEnabled => false;

        public bool IsInfoEnabled => false;

        public bool IsWarnEnabled => false;

        public bool IsErrorEnabled => true;

        public bool IsFatalEnabled => true;

        public void Debug<T>(T value)
        {
        }

        public void Debug<T>(IFormatProvider formatProvider, T value)
        {
        }

        public void Debug(Exception exception, [Localizable(false)] string message)
        {
        }

        public void Debug(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {
        }

        public void Debug([Localizable(false)] string message)
        {
        }

        void IFullLogger.Debug<T>([Localizable(false)] string message)
        {
        }

        public void Debug([Localizable(false)] string message, params object[] args)
        {
        }

        void IFullLogger.Debug<T>([Localizable(false)] string message, params object[] args)
        {
        }

        public void Debug<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
        {
        }

        public void Debug<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
        }

        public void Debug<TArgument>([Localizable(false)] string messageFormat, TArgument argument)
        {
        }

        public void Debug<TArgument1, TArgument2>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9, TArgument10>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9, TArgument10 argument10)
        {
        }

        public void Debug<TArgument>(Exception exception, [Localizable(false)] string messageFormat, TArgument argument)
        {
        }

        public void Debug<TArgument1, TArgument2>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9)
        {
        }

        public void Debug<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9, TArgument10>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9, TArgument10 argument10)
        {
        }

        public void DebugException([Localizable(false)] string message, Exception exception)
        {
        }

        public void Error<T>(T value)
        {
        }

        public void Error<T>(IFormatProvider formatProvider, T value)
        {
        }

        public void Error(Exception exception, [Localizable(false)] string message)
        {
            Crashes.TrackError(exception, new Dictionary<string, string>
            {
                { "message",message}
                });
        }

        public void Error(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {
        }

        public void Error([Localizable(false)] string message)
        {
        }

        void IFullLogger.Error<T>([Localizable(false)] string message)
        {
        }

        public void Error([Localizable(false)] string message, params object[] args)
        {
        }

        void IFullLogger.Error<T>([Localizable(false)] string message, params object[] args)
        {
        }

        public void Error<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
        {
        }

        public void Error<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
        }

        public void Error<TArgument>([Localizable(false)] string messageFormat, TArgument argument)
        {
        }

        public void Error<TArgument1, TArgument2>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9, TArgument10>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9, TArgument10 argument10)
        {
        }

        public void Error<TArgument>(Exception exception, [Localizable(false)] string messageFormat, TArgument argument)
        {
        }

        public void Error<TArgument1, TArgument2>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9)
        {
        }

        public void Error<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9, TArgument10>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9, TArgument10 argument10)
        {
        }

        public void ErrorException([Localizable(false)] string message, Exception exception)
        {
            Crashes.TrackError(exception, new Dictionary<string, string>
            {
                { "message",message},
                });
        }

        public void Fatal<T>(T value)
        {
        }

        public void Fatal<T>(IFormatProvider formatProvider, T value)
        {
        }

        public void Fatal(Exception exception, [Localizable(false)] string message)
        {
            Crashes.TrackError(exception, new Dictionary<string, string>
            {
                { "message",message},
                });
        }

        public void Fatal(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {
        }

        public void Fatal([Localizable(false)] string message)
        {
        }

        void IFullLogger.Fatal<T>([Localizable(false)] string message)
        {
        }

        public void Fatal([Localizable(false)] string message, params object[] args)
        {
        }

        void IFullLogger.Fatal<T>([Localizable(false)] string message, params object[] args)
        {
        }

        public void Fatal<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
        {
        }

        public void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
        }

        public void Fatal<TArgument>([Localizable(false)] string messageFormat, TArgument argument)
        {
        }

        public void Fatal<TArgument1, TArgument2>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9, TArgument10>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9, TArgument10 argument10)
        {
        }

        public void Fatal<TArgument>(Exception exception, [Localizable(false)] string messageFormat, TArgument argument)
        {
            Crashes.TrackError(exception, new Dictionary<string, string>
            {
                { "message",messageFormat},
                });
        }

        public void Fatal<TArgument1, TArgument2>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9)
        {
        }

        public void Fatal<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9, TArgument10>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9, TArgument10 argument10)
        {
        }

        public void FatalException([Localizable(false)] string message, Exception exception)
        {
            Crashes.TrackError(exception, new Dictionary<string, string>
            {
                { "message",message},
                });
        }

        public void Info<T>(T value)
        {
        }

        public void Info<T>(IFormatProvider formatProvider, T value)
        {
        }

        public void Info(Exception exception, [Localizable(false)] string message)
        {

        }

        public void Info(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {

        }

        public void Info([Localizable(false)] string message)
        {

        }

        void IFullLogger.Info<T>([Localizable(false)] string message)
        {

        }

        public void Info([Localizable(false)] string message, params object[] args)
        {

        }

        void IFullLogger.Info<T>([Localizable(false)] string message, params object[] args)
        {

        }

        public void Info<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
        {

        }

        public void Info<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {

        }

        public void Info<TArgument>([Localizable(false)] string messageFormat, TArgument argument)
        {

        }

        public void Info<TArgument1, TArgument2>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9, TArgument10>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9, TArgument10 argument10)
        {

        }

        public void Info<TArgument>(Exception exception, [Localizable(false)] string messageFormat, TArgument argument)
        {

        }

        public void Info<TArgument1, TArgument2>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9)
        {

        }

        public void Info<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9, TArgument10>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9, TArgument10 argument10)
        {

        }

        public void InfoException([Localizable(false)] string message, Exception exception)
        {

        }

        public void Warn<T>(T value)
        {

        }

        public void Warn<T>(IFormatProvider formatProvider, T value)
        {

        }

        public void Warn(Exception exception, [Localizable(false)] string message)
        {

        }

        public void Warn(IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {

        }

        public void Warn([Localizable(false)] string message)
        {

        }

        void IFullLogger.Warn<T>([Localizable(false)] string message)
        {

        }

        public void Warn([Localizable(false)] string message, params object[] args)
        {

        }

        void IFullLogger.Warn<T>([Localizable(false)] string message, params object[] args)
        {

        }

        public void Warn<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
        {

        }

        public void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {

        }

        public void Warn<TArgument>([Localizable(false)] string messageFormat, TArgument argument)
        {

        }

        public void Warn<TArgument1, TArgument2>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9, TArgument10>([Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9, TArgument10 argument10)
        {

        }

        public void Warn<TArgument>(Exception exception, [Localizable(false)] string messageFormat, TArgument argument)
        {

        }

        public void Warn<TArgument1, TArgument2>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9)
        {

        }

        public void Warn<TArgument1, TArgument2, TArgument3, TArgument4, TArgument5, TArgument6, TArgument7, TArgument8, TArgument9, TArgument10>(Exception exception, [Localizable(false)] string messageFormat, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, TArgument4 argument4, TArgument5 argument5, TArgument6 argument6, TArgument7 argument7, TArgument8 argument8, TArgument9 argument9, TArgument10 argument10)
        {

        }

        public void WarnException([Localizable(false)] string message, Exception exception)
        {

        }

        public void Write([Localizable(false)] string message, LogLevel logLevel)
        {
            Analytics.TrackEvent(message);
        }

        public void Write(Exception exception, [Localizable(false)] string message, LogLevel logLevel)
        {
            Crashes.TrackError(exception, new Dictionary<string, string>
            {
                { "message",message}
                });
        }

        public void Write([Localizable(false)] string message, [Localizable(false)] Type type, LogLevel logLevel)
        {
            Analytics.TrackEvent(message, new Dictionary<string, string>
            {
                {"type",type.Name},
            });
        }

        public void Write(Exception exception, [Localizable(false)] string message, [Localizable(false)] Type type, LogLevel logLevel)
        {
            Crashes.TrackError(exception, new Dictionary<string, string>
            {
                { "message",message},
                {"page",type.Name },
                });
        }


    }
}