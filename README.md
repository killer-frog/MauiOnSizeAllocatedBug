This Repo is to demo the OnSizeAllocated bug in Maui (android).

On on **iOS** OnSizeAllocated is correctly called when the device is rotated

On **Android** this event is not fired when rotating the tablet  (in fact no events are fired from the AppShell.cs file when the device is rotated)
