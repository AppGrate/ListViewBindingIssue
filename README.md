# ListViewBindingIssue
There is a ListView binded to a ObservableCollection of string. Listview has one label and one UserControl (containing nothing but a label). Both are binded to the same collection.

Also, there is a button which generate some random data for the collection.

Problem is when I run the app and click on Generate Data button the label gets updated but not the UserControl.
