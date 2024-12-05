# Project 5: White Wine Quality Analysis and Prediction

Welcome to **Project 5: White Wine Quality Analysis and Prediction**. This Python-based project explores data analysis, visualisation, clustering, classification models, and neural networks using a dataset of white wine chemical properties. The primary goal is to predict wine quality based on its chemical characteristics.

## Key Features
- **Interactive Notebook**: Opening the Jupyter Notebook on GitHub runs the code and displays the results automatically.
- **Comprehensive Analysis**: Covers data exploration, visualisation, clustering, and classification techniques.
- **Machine Learning Models**: Includes Decision Trees, k-Nearest Neighbors (KNN), Random Forests, and Neural Networks.

---

## Data Exploration and Visualization

### Dataset Overview
The dataset consists of 12 attributes related to the chemical properties of white wine and a target variable (`quality`). 

- **Shape**: 4898 rows × 12 columns
- **Target**: `quality` (rated on a 10-point scale)

### Visualizations
1. **Histograms**: Distribution of key attributes.
2. **Correlation Matrix**: Heatmap to identify relationships between features.
3. **Scatter Plots**: Relationships between features like alcohol and quality.
4. **Pair Plots and Box Plots**: In-depth look at feature distributions.

---

## Clustering

### Techniques
- **K-Means**: Applied with `k = 3`, `k = 4`, and `k = 5` using dimensionality reduction (PCA).
- **Hierarchical Clustering**: Explored for comparison.

### Results
- Moderate cluster separability with silhouette scores peaking at ~0.54.
- Feature reduction led to slightly improved clustering performance for fewer features.

---

## Classification Models

### Experimental Setup
The quality column was categorized into three classes:
- **Low**: Quality < 6
- **Medium**: Quality = 6
- **High**: Quality > 6

#### Models Used:
1. **Decision Tree Classifier**:
   - Accuracy: 65% (11 features), 62% (3 features).
   - Alcohol, density, and chlorides identified as key features.

2. **K-Nearest Neighbors (KNN)**:
   - Optimal `k`: 1.
   - Accuracy: 69% (11 features), 64% (3 features).

3. **Random Forest Classifier**:
   - Best performance with 73% accuracy (11 features).
   - Robust to feature reduction, maintaining 66% accuracy with 3 features.

### Observations
- Reducing features from 11 to 7 had minimal performance impact.
- Random Forest outperformed Decision Tree and KNN across all feature subsets.

---

## Neural Networks

### Architecture
- A feedforward neural network with:
  - **Input Layer**: Corresponding to the number of features.
  - **Hidden Layers**: Dense layers with dropout for regularization.
  - **Output Layer**: Predicting quality categories (Low, Medium, High).

### Results
- Training accuracy reached **69.96%**, with validation accuracy at **34-35%**.
- Highlighted the need for advanced techniques like transfer learning or additional data for improved generalisation.

---

## Conclusion

This project demonstrates how data-driven techniques can predict wine quality effectively. Key insights include:
1. **Model Performance**: Random Forest showed the highest accuracy and robustness.
2. **Feature Importance**: Alcohol, density, and chlorides were the most significant predictors.
3. **Feature Reduction**: Reducing features had varying impacts depending on the model used.
4. **Neural Networks**: Promising performance but limited generalisation.

---

## How to Use

1. Open the Jupyter Notebook on GitHub.
2. The notebook will automatically execute, showing all analyses, results, and visualisations.
3. Explore clustering, classification models, and neural network outputs interactively.

---

This project highlights the power of machine learning in predicting outcomes from chemical properties and serves as a robust template for similar analyses. Enjoy exploring the world of data science with wine!

