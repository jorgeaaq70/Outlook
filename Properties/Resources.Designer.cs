﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlexConfirmMail.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FlexConfirmMail.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   このアドオンについて に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string AboutAddon {
            get {
                return ResourceManager.GetString("AboutAddon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        /// </summary>
        public static System.Drawing.Bitmap banner {
            get {
                object obj = ResourceManager.GetObject("banner", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   キャンセル に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Cancel {
            get {
                return ResourceManager.GetString("Cancel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   送信カウントダウン設定 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigCount {
            get {
                return ResourceManager.GetString("ConfigCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   カウントダウンのダイアログの「いますぐ送信」ボタンを有効化する に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigCountAllowSkip {
            get {
                return ResourceManager.GetString("ConfigCountAllowSkip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   メール送信前のカウントダウンを有効化する に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigCountEnabled {
            get {
                return ResourceManager.GetString("ConfigCountEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   送信までのカウントダウン秒数: に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigCountSeconds {
            get {
                return ResourceManager.GetString("ConfigCountSeconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   一般設定 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigGeneral {
            get {
                return ResourceManager.GetString("ConfigGeneral", resourceCulture);
            }
        }
        
        /// <summary>
        ///   宛先が社内ドメインのみの場合は確認をスキップする に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigMainSkipIfNoExt {
            get {
                return ResourceManager.GetString("ConfigMainSkipIfNoExt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   その他の設定 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigMisc {
            get {
                return ResourceManager.GetString("ConfigMisc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   To/CCに一定数以上のドメインが含まれている場合に警告する に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigSafeBccEnabled {
            get {
                return ResourceManager.GetString("ConfigSafeBccEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   警告対象となるドメインの数: に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigSafeBccThreshold {
            get {
                return ResourceManager.GetString("ConfigSafeBccThreshold", resourceCulture);
            }
        }
        
        /// <summary>
        ///   件以上 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigSafeBccThresholdSuffix {
            get {
                return ResourceManager.GetString("ConfigSafeBccThresholdSuffix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   返信時に新しいドメインが追加されていた場合警告する に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigSafeNewDomainsEnabled {
            get {
                return ResourceManager.GetString("ConfigSafeNewDomainsEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   社内ドメイン設定 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigTrustedDomains {
            get {
                return ResourceManager.GetString("ConfigTrustedDomains", resourceCulture);
            }
        }
        
        /// <summary>
        ///   注意が必要なドメイン設定 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigUnsafeDomains {
            get {
                return ResourceManager.GetString("ConfigUnsafeDomains", resourceCulture);
            }
        }
        
        /// <summary>
        ///   注意が必要なファイル名設定 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigUnsafeFiles {
            get {
                return ResourceManager.GetString("ConfigUnsafeFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   警告設定 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigWarning {
            get {
                return ResourceManager.GetString("ConfigWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   FlexConfirmMail設定 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigWindowTitle {
            get {
                return ResourceManager.GetString("ConfigWindowTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   秒後に送信します に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string CountSendInSeconds {
            get {
                return ResourceManager.GetString("CountSendInSeconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   送信カウントダウン - FlexConfirmMail に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string CountWindowTitle {
            get {
                return ResourceManager.GetString("CountWindowTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        /// </summary>
        public static System.Drawing.Bitmap logo {
            get {
                object obj = ResourceManager.GetObject("logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   一括チェック に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string MainCheckAll {
            get {
                return ResourceManager.GetString("MainCheckAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   外部の送信先 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string MainExternal {
            get {
                return ResourceManager.GetString("MainExternal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   添付ファイル／その他の警告 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string MainFile {
            get {
                return ResourceManager.GetString("MainFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [添付ファイル] {0} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string MainFilesWarning {
            get {
                return ResourceManager.GetString("MainFilesWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [警告] To・Ccに{0}件以上のドメインが含まれています。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string MainSafeBccWarning {
            get {
                return ResourceManager.GetString("MainSafeBccWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   宛先に多数のドメインが検知されました。
        ///ToおよびCcに含まれるメールアドレスはすべての受取人が確認できるため、
        ///アナウンスなどを一斉送信する場合はBccを利用して宛先リストを隠します。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string MainSafeBccWarningHint {
            get {
                return ResourceManager.GetString("MainSafeBccWarningHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   社内の送信先 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string MainTrusted {
            get {
                return ResourceManager.GetString("MainTrusted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [警告] 注意が必要なドメイン（{0}）が宛先に含まれています。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string MainUnsafeDomainsWarning {
            get {
                return ResourceManager.GetString("MainUnsafeDomainsWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   このドメインは誤送信の可能性が高いため、再確認を促す警告を出してします。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string MainUnsafeDomainsWarningHint {
            get {
                return ResourceManager.GetString("MainUnsafeDomainsWarningHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   [警告] 注意が必要なファイル名（{0}）が含まれています。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string MainUnsafeFilesWarning {
            get {
                return ResourceManager.GetString("MainUnsafeFilesWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   添付ファイルに注意が必要な単語が含まれているため、
        ///再確認を促す警告を出しています。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string MainUnsafeFilesWarningHint {
            get {
                return ResourceManager.GetString("MainUnsafeFilesWarningHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   FlexConfirmMail設定 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string RibbonButtonFlexConfirmMail {
            get {
                return ResourceManager.GetString("RibbonButtonFlexConfirmMail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   送信チェック に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string RibbonGroupFlexConfirmMail {
            get {
                return ResourceManager.GetString("RibbonGroupFlexConfirmMail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   保存して閉じる に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string SaveAndQuit {
            get {
                return ResourceManager.GetString("SaveAndQuit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   秒 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Seconds {
            get {
                return ResourceManager.GetString("Seconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   送信 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Send {
            get {
                return ResourceManager.GetString("Send", resourceCulture);
            }
        }
        
        /// <summary>
        ///   今すぐ送信 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string SendNow {
            get {
                return ResourceManager.GetString("SendNow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   動作ログ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string TextLog {
            get {
                return ResourceManager.GetString("TextLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   社内ドメイン に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string TrustedDomains {
            get {
                return ResourceManager.GetString("TrustedDomains", resourceCulture);
            }
        }
        
        /// <summary>
        ///   example.com
        ///-example.org に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string TrustedDomainsExample {
            get {
                return ResourceManager.GetString("TrustedDomainsExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   # 社内ドメイン設定 ###
        ///# 組織設定により、社内ドメインとして以下が指定されています。
        ///#
        ///# {0}
        ///#
        ///# さらにドメインを追加する場合は、以下に1行ずつ入力してください。
        ///# また、先頭に「-」をつけると、ドメインを除外することができます。
        ///# 指定にはワイルドカード（*および?）も使用可能です。
        ///##################################
        ///
        ///{1} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string TrustedDomainsPolicy {
            get {
                return ResourceManager.GetString("TrustedDomainsPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   # 社内ドメイン設定 ###
        ///#
        ///# (1) 送信時に社内の宛先として扱うドメインを指定します。
        ///# (2) 以下の例のように一行に一件ずつ記載します。
        ///# (3) 冒頭が「#」から始まる行は無視されます。
        ///# (4) 指定にはワイルドカード（*および?）を使用可能です。
        ///#
        ///##################################
        ///
        ///example.com
        ///example.org に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string TrustedDomainsTemplate {
            get {
                return ResourceManager.GetString("TrustedDomainsTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   注意が必要なドメイン に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnsafeDomains {
            get {
                return ResourceManager.GetString("UnsafeDomains", resourceCulture);
            }
        }
        
        /// <summary>
        ///   example.com
        ///-example.org に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnsafeDomainsExample {
            get {
                return ResourceManager.GetString("UnsafeDomainsExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   # 注意が必要なドメイン設定 ###
        ///# 組織設定により、注意が必要なドメインとして以下が指定されています。
        ///#
        ///# {0}
        ///#
        ///# さらにドメインを追加する場合は、以下に1行ずつ入力してください。
        ///# また、先頭に「-」をつけると、ドメインを除外することができます。
        ///# 指定にはワイルドカード（*および?）も使用可能です。
        ///##################################
        ///
        ///{1} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnsafeDomainsPolicy {
            get {
                return ResourceManager.GetString("UnsafeDomainsPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   # 注意が必要なドメイン設定 ###
        ///#
        ///# (1) 送信時に警告対象とする注意ドメインを指定します。
        ///# (2) 以下の例のように一行に一件ずつ記載します。
        ///# (3) 冒頭が「#」から始まる行は無視されます。
        ///# (4) 指定にはワイルドカード（*および?）を使用可能です。
        ///#
        ///##################################
        ///
        ///example.com
        ///example.org に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnsafeDomainsTemplate {
            get {
                return ResourceManager.GetString("UnsafeDomainsTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   注意が必要なファイル名 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnsafeFiles {
            get {
                return ResourceManager.GetString("UnsafeFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   社外秘
        ///-除外キーワード に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnsafeFilesExample {
            get {
                return ResourceManager.GetString("UnsafeFilesExample", resourceCulture);
            }
        }
        
        /// <summary>
        ///   # 注意が必要なファイル名設定 ###
        ///# 組織設定により、注意が必要なファイル名として以下が指定されています。
        ///#
        ///# {0}
        ///#
        ///# さらにキーワードを追加する場合は、以下に1行ずつ入力してください。
        ///# また、先頭に「-」をつけると、キーワードを除外することができます。
        ///# 指定にはワイルドカード（*および?）も使用可能です。
        ///##################################
        ///
        ///{1} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnsafeFilesPolicy {
            get {
                return ResourceManager.GetString("UnsafeFilesPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   # 注意が必要なファイル名設定 ###
        ///#
        ///# (1) 添付ファイルに含まれる場合に警告する注意ワードを指定します。
        ///# (2) 以下の例のように一行に一件ずつ記載します。
        ///# (3) 冒頭が「#」から始まる行は無視されます。
        ///#
        ///##################################
        ///
        ///社外秘
        ///機密 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnsafeFilesTemplate {
            get {
                return ResourceManager.GetString("UnsafeFilesTemplate", resourceCulture);
            }
        }
    }
}
