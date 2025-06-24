# WinUI3-Namespace-Map

This repository documents the key `Microsoft.UI.*` namespaces used in WinUI 3 development, ordered by practical relevance and architectural layering — from core UI composition to low-level rendering, input, and system integration.

---

## Core UI and Layout

| Namespace | Purpose |
|-----------|---------|
| `Microsoft.UI` | Base types and WinAppSDK integration. |
| `Microsoft.UI.Xaml` | Main UI framework, visual tree, layout engine. |
| `Microsoft.UI.Xaml.Controls` | Standard XAML controls. |
| `Microsoft.UI.Xaml.Controls.Primitives` | Control templates and reusable UI primitives. |
| `Microsoft.UI.Xaml.Media` | Brushes, visuals, transforms. |
| `Microsoft.UI.Xaml.Media.Animation` | Declarative animations and transitions. |
| `Microsoft.UI.Xaml.Shapes` | Vector shapes for lightweight UI. |
| `Microsoft.UI.Xaml.Input` | Input event routing and gesture hooks. |
| `Microsoft.UI.Xaml.Navigation` | Page navigation and frame stack. |

---

## Data, Markup, and Visual Assets

| Namespace | Purpose |
|-----------|---------|
| `Microsoft.UI.Xaml.Data` | Data binding and INotifyPropertyChanged. |
| `Microsoft.UI.Xaml.Documents` | Rich text content and inline formatting. |
| `Microsoft.UI.Xaml.Markup` | XAML parsing and serialization. |
| `Microsoft.UI.Xaml.Media.Imaging` | Bitmap and SVG rendering. |
| `Microsoft.UI.Xaml.Resources` | Theming and resource dictionaries. |
| `Microsoft.UI.Xaml.Printing` | Print pipeline integration. |
| `Microsoft.UI.Xaml.Interop` | XAML interop and type resolution. |
| `Microsoft.UI.Xaml.CustomAttributes` | Custom attributes for XAML metadata. |
| `Microsoft.UI.Xaml.Controls.AnimatedVisuals` | Lottie animations and visual states. |
| `Microsoft.UI.Xaml.XamlTypeInfo` | Reflection metadata for the XAML runtime. |

---

## Composition and Visual Layer

| Namespace | Purpose |
|-----------|---------|
| `Microsoft.UI.Xaml.Hosting` | Visual hosting for Composition integration. |
| `Microsoft.UI.Composition` | Implicit animations, visual tree manipulation. |
| `Microsoft.UI.Composition.Effects` | Blend modes, blur, shadows, and custom shaders. |
| `Microsoft.UI.Composition.Interactions` | Manipulation and input gestures for visuals. |
| `Microsoft.UI.Composition.Scenes` | Real-time 3D scene graph. |
| `Microsoft.UI.Composition.SystemBackdrops` | Acrylic, Mica, and other system backdrops. |

---

## Input and Interaction

| Namespace | Purpose |
|-----------|---------|
| `Microsoft.UI.Input` | Low-level input for pointer, touch, pen. |
| `Microsoft.UI.Input.DragDrop` | Drag-and-drop support. |
| `Microsoft.UI.Input.Interop` | Input interop with Win32 APIs. |
| `Microsoft.UI.Dispatching` | Dispatcher queue for multi-threaded scenarios. |

---

## Windowing and Platform Integration

| Namespace | Purpose |
|-----------|---------|
| `Microsoft.UI.Windowing` | App window control (size, mode, placement). |
| `Microsoft.UI.System` | System-level integration (themes, settings). |
| `Microsoft.UI.Content` | Hosting and embedding content. |
| `Microsoft.UI.Text` | RichEdit text services and formatting. |

---

## Automation and Accessibility

| Namespace | Purpose |
|-----------|---------|
| `Microsoft.UI.Xaml.Automation` | Base automation infrastructure. |
| `Microsoft.UI.Xaml.Automation.Peers` | Exposure of UI elements to accessibility tools. |
| `Microsoft.UI.Xaml.Automation.Provider` | Custom automation pattern support. |
| `Microsoft.UI.Xaml.Automation.Text` | Text automation for editable controls. |

---

## Internals and Diagnostics

| Namespace | Purpose |
|-----------|---------|
| `Microsoft.UI.Composition.Diagnostics` | Visual diagnostics and debugging tools. |
| `Microsoft.UI.Composition.Core` | Internal rendering engine interfaces. |
| `Microsoft.UI.Xaml.Media.Media3D` | Perspective transforms and 3D effects. |
