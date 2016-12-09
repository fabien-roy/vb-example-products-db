﻿Public Class VariablesGlobales
  Public Shared ADMIN_CONNECTION As Boolean = False
  Public Shared ReadOnly ADMIN_UTILISATEUR As String = "admin"
  Public Shared ReadOnly ADMIN_MDP As String = "4242"

  Public Shared ReadOnly TPS_VALEUR As Double = 0.05
  Public Shared ReadOnly TVQ_VALEUR As Double = 0.09975

  Public Shared ReadOnly FACT_NOM As String = "COOP"
  Public Shared ReadOnly FACT_ADD As String = "175, rue De La Vérendrye"
  Public Shared ReadOnly FACT_VILLE As String = "Sept-Îles"
  Public Shared ReadOnly FACT_PROV As String = "QC"
  Public Shared ReadOnly FACT_CP As String = "G4R 5B7"
  Public Shared ReadOnly FACT_TEL As String = "418 962-9848"
  Public Shared ReadOnly FACT_FAX As String = "418 962-2458"
  Public Shared ReadOnly FACT_COURRIEL As String = "communications@cegepsi.ca"

  Public Shared ReadOnly DROIT_INVENTAIRE_SELECT As Int16 = 1     ' Voir le tab inventaire et le DGV (Contrôle de base)     1   1000 0000 0000 0000 
  Public Shared ReadOnly DROIT_INVENTAIRE_UPDATE As Int16 = 2     ' Mettre à jour un inventaire                             2   0100 0000 0000 0000
  Public Shared ReadOnly DROIT_INVENTAIRE_INSERT As Int16 = 4     ' Ajouter un inventaire                                   3   0010 0000 0000 0000
  Public Shared ReadOnly DROIT_INVENTAIRE_DELETE As Int16 = 8     ' Supprimer un inventaire                                 4   0001 0000 0000 0000
  Public Shared ReadOnly DROIT_INVENTAIRE_ADMIN As Int16 = 16     ' Voir l'estimation de l'inventaire et les prix d'achats  5   0000 1000 0000 0000
  Public Shared ReadOnly DROIT_FACTURE_SELECT As Int16 = 32       ' Voir le tab facture et le DGV                           6   0000 0100 0000 0000
  Public Shared ReadOnly DROIT_FACTURE_UPDATE As Int16 = 64       ' Mettre à jour une facture                               7   0000 0010 0000 0000
  Public Shared ReadOnly DROIT_FACTURE_INSERT As Int16 = 128      ' Ajouter une facture (Contrôle de base)                  8   0000 0001 0000 0000
  Public Shared ReadOnly DROIT_FACTURE_DELETE As Int16 = 256      ' Supprimer une facture                                   9   0000 0000 0100 0000
  Public Shared ReadOnly DROIT_UTILISATEUR_SELECT As Int16 = 512  ' Voir le tab utilisateur et le DGV                       10  0000 0000 0010 0000
  Public Shared ReadOnly DROIT_UTILISATEUR_UPDATE As Int16 = 1024 ' Mettre à jour un utilisateur                            11  0000 0000 0001 0000
  Public Shared ReadOnly DROIT_UTILISATEUR_INSERT As Int16 = 2048 ' Ajouter un utilisateur                                  12  0000 0000 0000 1000
  Public Shared ReadOnly DROIT_UTILISATEUR_DELETE As Int16 = 4096 ' Supprimer un utilisateur                                13  0000 0000 0000 0100
End Class