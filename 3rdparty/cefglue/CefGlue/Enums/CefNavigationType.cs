//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_menu_id_t.
//
namespace Xilium.CefGlue
{
    /// <summary>
    /// Supported menu IDs. Non-English translations can be provided for the
    /// IDS_MENU_* strings in CefResourceBundleHandler::GetLocalizedString().
    /// </summary>
    public enum CefNavigationType
    {
        NAVIGATION_LINK_CLICKED = 0,
        NAVIGATION_FORM_SUBMITTED,
        NAVIGATION_BACK_FORWARD,
        NAVIGATION_RELOAD,
        NAVIGATION_FORM_RESUBMITTED,
        NAVIGATION_OTHER,
    }
}
