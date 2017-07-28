Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Geometry

Namespace HorizontalAtributes

    Public Class Commands
        ' Class varaible to store the instance of our overrule
        Private Shared myOverrule As KeepstraightOverrule

        <CommandMethod("KeepStraight")>
        Public Shared Sub ImplementOverrule()


            'We only want to cerate our overr7ule instance one,
            ' so we check if it alreqady exists before we create it
            ' (i.e. this may be the 2nd time we've run the command)
            If myOverrule Is Nothing Then
                'Instantiate our overrule class
                myOverrule = New KeepstraightOverrule
                'Register the overrule
                Overrule.AddOverrule(
                    RXClass.GetClass(GetType(AttributeReference)),
                    myOverrule, False)
            End If
            'make sure overruling is turned on so our overrule works
            Overrule.Overruling = True

        End Sub

    End Class

    'our custom overrule class derived from TransformOverrule
    Public Class KeepstraightOverrule
        Inherits TransformOverrule

        'We want to chane how an AttributeReference responds to being
        'transformed (moved, rotatred, etc.), so we override its
        'standard TransformBy function.

        Public Overrides Sub TransformBy(ByVal entity As Entity,
                                         ByVal transform As Matrix3d)

            'Call the normal TransformedBy funtion for the attribute
            'referenc we're overruling.
            MyBase.TransformBy(entity, transform)
            'We know entity must be an AttributeReference because
            'that is the only entity we registered the overrule for.
            Dim attRef As AttributeReference = entity
            'Set rotation of attribute to 0 (horizontal)
            attRef.Rotation = 0.0

        End Sub
    End Class
End Namespace