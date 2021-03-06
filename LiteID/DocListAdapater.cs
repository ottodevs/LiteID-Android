using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

public class DocListAdapter : BaseAdapter<Document>
{
    DocumentList documents;
    Activity context;
    public DocListAdapter(Activity context, DocumentList documents) : base()
    {
        this.context = context;
        this.documents = documents;
    }
    public override long GetItemId(int position)
    {
        return position;
    }
    public override Document this[int position]
    {
        get { return documents.Documents[position]; }
    }
    public override int Count
    {
        get { return documents.Documents.Count; }
    }
    public override View GetView(int position, View convertView, ViewGroup parent)
    {
        View view = convertView;
        if (view == null)
        {
            view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
        }
        TextView textView = view.FindViewById<TextView>(Android.Resource.Id.Text1);
        textView.Text = documents.Documents[position].Name;
        textView.SetTextColor(Android.Graphics.Color.Black);
        return view;
    }
}